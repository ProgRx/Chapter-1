<Query Kind="Statements">
  <Reference Relative="..\References\System.Reactive.dll">System.Reactive.dll</Reference>
  <Reference Relative="..\References\Microsoft.Reactive.Testing.dll">Microsoft.Reactive.Testing.dll</Reference>
  <Reference Relative="..\References\RxBookLinqpadHelper.dll">RxBookLinqpadHelper.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
  <Namespace>RxBookLinqpadHelper</Namespace>
</Query>

var input = Observable.Range(1,15);
input.Subscribe(x => Console.WriteLine("The number is {0}", x));
