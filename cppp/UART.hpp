#ifndef UART_HPP
#define UART_HPP
#pragma once
#include <SFML/Graphics.hpp>
#include <windows.h>
#include <string>
#include <iostream>
#include <vector>
#include <cstdint>
#include <algorithm>
#include <tchar.h>

struct DATASET
{
   uint8_t id;
   std::vector<float> values;
   sf::Color color = sf::Color::Red;
   std::string name = "";

} typedef DATSET;

struct PACKET
{
   uint8_t id;
   float value = 0;
} typedef PACKET;

class UART
{
public:
   UART(std::string comPort, int baud, std::vector<DATASET> *sets, sf::Mutex *mutex);
   ~UART();
   void init();
   void setMessageSize(uint8_t messageSize);
   void setByteOrder(bool lsbFirst);
   std::vector<uint8_t> readBytes();
   PACKET readPacket();

   void addDataFromPacket();

private:
   void addDataFromPacket(std::vector<DATASET> *sets);
   float bytes2float(std::vector<uint8_t> data);
   int _baudRate = 115200;
   std::string _comPort;
   HANDLE _handle;
   uint8_t _messageSize = 6;
   uint8_t _plotPacketID = 0x69;
   bool _lsbFirst = false;
   std::vector<DATASET> *_sets;
   sf::Mutex *_mutex;
};

#endif // UART_HPP