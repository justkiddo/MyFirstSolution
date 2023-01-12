using Homework_1._16;



DirectoryWorker dw = new DirectoryWorker();

dw.SetPath("F:\\TestDirectory\\");

dw.FilesInDirectory();

dw.DirectoryFileInfo();

dw.CountCatExtFiles("*.txt");

dw.CountDirExtFiles("*.txt");

dw.FilesInCat();