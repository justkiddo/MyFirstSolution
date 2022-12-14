using Homework_1._8.Classes;


Printer prt = new Printer();
BluePrinter bprt= new BluePrinter();
GreenPrinter gprt = new GreenPrinter();

//prt.Print("test");
//bprt.Print("test");
//gprt.Print("test");

Room rm = new Room();

rm.NewGreenPrinter();
rm.MakeThisLazyPrinterWork("is this green?");

rm.NewBluePrinter();
rm.MakeThisLazyPrinterWork("is this blue?");


rm.NewPrinter();
rm.MakeThisLazyPrinterWork("is this white?");