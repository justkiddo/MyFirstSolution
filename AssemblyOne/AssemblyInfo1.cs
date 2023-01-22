using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;

// В проектах SDK, таких как этот, некоторые атрибуты сборки, которые ранее определялись
// в этом файле, теперь автоматически добавляются во время сборки и заполняются значениями,
// заданными в свойствах проекта. Подробные сведения о том, какие атрибуты включены
// и как настроить этот процесс, см. на странице: https://aka.ms/assembly-info-properties.


// При установке значения false для параметра ComVisible типы в этой сборке становятся
// невидимыми для компонентов COM. Если вам необходимо получить доступ к типу в этой
// сборке из модели COM, установите значение true для атрибута ComVisible этого типа.

[assembly: ComVisible(false)]

// Следующий GUID служит для идентификации библиотеки типов typelib, если этот проект
// будет видимым для COM.


//[assembly: AssemblyTitle("NewTitle")]    // тут не работает, изменил в AssemblyOne\obj\Release\net6.0\AssemblyOne.AssemblyInfo.cs
[assembly: Description("some description")]
[assembly: Guid("0f739165-0f8b-4747-a3d1-9e684fadf65e")]
