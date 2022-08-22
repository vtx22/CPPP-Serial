#include <SFML/Graphics.hpp>
#include "cppp.hpp"
#include "UART.hpp"

#include <iostream>

std::vector<DATASET> uartData;
sf::Mutex mutex;

// cpp-serial COM1 115200 CHECKSUM LSBFIRST IGNORETIME LOGGING FULLSCREEN WIDTH HEIGHT
int main(int argc, char *argv[])
{
   if (argc < 10)
   {
      std::cout << "ERROR: Too few arguments!\n";
      return 0;
   }

   // UART INIT
   UART uart(argv[1], std::stoi(argv[2]), &uartData, &mutex);
   uart.setMessageSize(std::stoi(argv[3]) ? 8 : 6);
   uart.setByteOrder(std::stoi(argv[4]));

   sf::Thread uartThread(&UART::addDataFromPacket, &uart);
   uartThread.launch();

   sf::ContextSettings settings;
   settings.antialiasingLevel = 4;

   sf::RenderWindow window(sf::VideoMode(std::stoi(argv[8]), std::stoi(argv[9])), "CPPP - CPlusPlusPlotter | Serial Plotter", std::stoi(argv[7]) ? (sf::Style::Fullscreen) : (sf::Style::Close), settings);

   CPPP plotter(&window);

   while (window.isOpen())
   {
      sf::Event event;
      while (window.pollEvent(event))
      {
         if (event.type == sf::Event::Closed)
         {
            window.close();
         }
      }

      window.clear();
      plotter.addPlot(80);
      plotter.setTitle("Serial Data");
      plotter.setPlotMode(XY_ONLY);
      mutex.lock();
      for (auto const &data : uartData)
      {
         plotter.newDataset(data.values, LINE, data.color);
      }
      mutex.unlock();
      plotter.showPlot();

      window.display();
   }

   uartThread.terminate();

   return 0;
}
