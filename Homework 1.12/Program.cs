using Homework_1._12.Classes;
using Homework_1._12.Classes._2;



// 1 ______________________________________________________________________

//Words word = new Words();
//string words = "В предыдущих примерах тип возвращаемого значения " +
//    "итераторы — IEnumerable<T> (в неуниверсических случаях используйте IEnumerable в " +
//    "качестве возвращаемого типа итератора). Вы также можете использовать IAsyncEnumerable<T> в " +
//    "качестве возвращаемого типа итератора. Это делает итератор асинхронным. Используйте инструкцию await " +
//    "foreach для итерации результатов итератора, как показано в следующем примере:";

//word.GetWordsList(word.GetList(words));

// 2 ______________________________________________________________________



Worker worker1 = new Worker("john", 4315);
Worker worker2 = new Worker("jack", 3211);
Worker worker3 = new Worker("jim", 2010);
Worker worker4 = new Worker("henry", 1234);
Worker worker5 = new Worker("arthur", 5346);
Worker worker6 = new Worker("bob", 1424);
WorkersList<Worker> cW = new WorkersList<Worker>();

cW.addWorker(worker1);
cW.addWorker(worker2);
cW.addWorker(worker3);
cW.addWorker(worker4);
cW.addWorker(worker5);
cW.addWorker(worker6);

cW.ShowWorkers();


