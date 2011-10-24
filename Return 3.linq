<Query Kind="Statements">
  <Reference Relative="..\References\System.Reactive.dll">..\References\System.Reactive.dll</Reference>
  <Reference Relative="..\References\Microsoft.Reactive.Testing.dll">..\References\Microsoft.Reactive.Testing.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
</Query>

/* Return 3:
 *
 * Demonstrate that Return is a Cold Observable (i.e. that it produces a new
 * stream of events every time someone subscribes to it)
 */

var input = Observable.Return(42);
input.Subscribe(x => Console.WriteLine("Subscription 1: {0}", x));
input.Subscribe(x => Console.WriteLine("Subscription 2: {0}", x));
