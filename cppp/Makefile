all: compile link

compile:
	g++ -Isfml/include -c cppp-serial.cpp cppp.cpp UART.cpp -Ofast -pthread

link: 
	g++ cppp-serial.o cppp.o UART.o -o cppp-serial -Lsfml/lib -lsfml-graphics -lsfml-window -lsfml-system -lpthread
