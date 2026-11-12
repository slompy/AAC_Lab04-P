using System.Runtime.InteropServices;


// 1.

// System.Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
// System.Console.WriteLine($"Архитектура процесса: {RuntimeInformation.ProcessArchitecture}");
// System.Console.WriteLine($"64-битный процесс: {Environment.Is64BitProcess}");



// 2.

// using System.Diagnostics;

// System.Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");
// System.Console.WriteLine("Запуск вычислений...");

// Stopwatch timer = Stopwatch.StartNew();
// long result = 0;

// while (timer.Elapsed.TotalSeconds < 5)
// {
//     for (int i = 0; i < 1_000_000; i++)
//     {
//         result += i * i;
//     }
// }

// System.Console.WriteLine($"Результат: {result}");
// System.Console.WriteLine("Готово.");

