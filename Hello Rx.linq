<Query Kind="Statements">
  <Reference Relative="..\RxBookLinqpadHelper\ext\System.Reactive.dll">D:\ProgrammingRx\Demo Code For Chapters\RxBookLinqpadHelper\ext\System.Reactive.dll</Reference>
  <Reference Relative="..\RxBookLinqpadHelper\ext\Microsoft.Reactive.Testing.dll">D:\ProgrammingRx\Demo Code For Chapters\RxBookLinqpadHelper\ext\Microsoft.Reactive.Testing.dll</Reference>
  <Reference Relative="..\RxBookLinqpadHelper\RxBookLinqpadHelper\bin\Debug\RxBookLinqpadHelper.dll">D:\ProgrammingRx\Demo Code For Chapters\RxBookLinqpadHelper\RxBookLinqpadHelper\bin\Debug\RxBookLinqpadHelper.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
  <Namespace>RxBookLinqpadHelper</Namespace>
</Query>

var input = Observable.Range(1,15);
input.Subscribe(x => Console.WriteLine("The number is {0}", x));