using Homework_1._8.Classes;


Printer prt = new Printer();
BluePrinter bprt= new BluePrinter();
GreenPrinter gprt = new GreenPrinter();

//prt.Print("test");
//bprt.Print("test");
//gprt.Print("test");

Room rm = new Room();

rm.NewGreenPrinter().Print("is this green?");

rm.NewBluePrinter().Print("is this blue?");

rm.NewPrinter().Print("is this white?");