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



Workers worker1 = new Workers("john", 4315);
Workers worker2 = new Workers("jack", 3211);
Workers worker3 = new Workers("jim", 2010);
Workers worker4 = new Workers("henry", 1234);
Workers worker5 = new Workers("arthur", 5346);
Workers worker6 = new Workers("bob", 1424);
WorkersList<Workers> cW = new WorkersList<Workers>();

cW.addWorker(worker1);
cW.addWorker(worker2);
cW.addWorker(worker3);
cW.addWorker(worker4);
cW.addWorker(worker5);
cW.addWorker(worker6);




