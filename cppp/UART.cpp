#include "UART.hpp"

UART::UART(std::string comPort, int baud, std::vector<DATASET> *sets, sf::Mutex *mutex) : _comPort(comPort), _baudRate(baud), _sets(sets), _mutex(mutex)
{
   init();
}

UART::~UART()
{
   CloseHandle(_handle);
}

void UART::init()
{
   _handle = CreateFile(_comPort.c_str(), GENERIC_READ, 0, 0, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, 0);

   if (_handle == INVALID_HANDLE_VALUE)
   {
      if (GetLastError() == ERROR_FILE_NOT_FOUND)
      {
         std::cout << "UART ERROR: COM Port not found!\n";
      }
      std::cout << "UART ERROR: Handle invalid!\n";
   }

   DCB dcbSerialParams = {0};

   if (!GetCommState(_handle, &dcbSerialParams))
   {
      std::cout << "UART ERROR: Cannot get Comm State!\n";
   }

   dcbSerialParams.BaudRate = _baudRate;
   dcbSerialParams.ByteSize = 8;
   dcbSerialParams.StopBits = ONESTOPBIT;
   dcbSerialParams.Parity = NOPARITY;

   if (!SetCommState(_handle, &dcbSerialParams))
   {
      std::cout << "UART ERROR: Cannot set Comm State!\n";
   }

   COMMTIMEOUTS timeouts = {0};
   timeouts.ReadIntervalTimeout = 2;
   timeouts.ReadTotalTimeoutConstant = 0;
   timeouts.ReadTotalTimeoutMultiplier = 0;
   if (!SetCommTimeouts(_handle, &timeouts))
   {
      std::cout << "UART ERROR: Cannot set Timeouts!\n";
   }
}

std::vector<uint8_t> UART::readBytes()
{
   std::vector<uint8_t> data(_messageSize, 0);
   DWORD dwBytesRead = 0;
   if (!ReadFile(_handle, &data[0], _messageSize, &dwBytesRead, NULL))
   {
      std::cout << "UART ERROR: Error while reading!\n";
   }
   return data;
}

void UART::setMessageSize(uint8_t messageSize)
{
   _messageSize = messageSize;
}

float UART::bytes2float(std::vector<uint8_t> data)
{
   if (!_lsbFirst)
   {
      std::reverse(data.begin(), data.end());
   }

   return *(float *)&data[0];
}

PACKET UART::readPacket()
{
   PACKET packet;
   std::vector<uint8_t> message;
   while (true)
   {
      message = readBytes();
      if (message.size() == _messageSize && message.at(0) == _plotPacketID)
      {
         break;
      }
   }

   packet.id = message.at(1);
   message.erase(message.begin(), message.begin() + 2);
   message.erase(message.begin() + 4, message.end());
   packet.value = bytes2float(message);

   return packet;
}

void UART::setByteOrder(bool lsbFirst)
{
   _lsbFirst = lsbFirst;
}

void UART::addDataFromPacket(std::vector<DATASET> *sets)
{
   while (true)
   {
      PACKET packet = readPacket();
      _mutex->lock();
      sets->at(packet.id).values.push_back(packet.value);
      _mutex->unlock();
   }
}

void UART::addDataFromPacket()
{
   addDataFromPacket(_sets);
}