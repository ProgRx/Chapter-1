<Query Kind="Statements">
  <Reference Relative="..\References\System.Reactive.dll">..\References\System.Reactive.dll</Reference>
  <Reference Relative="..\References\Microsoft.Reactive.Testing.dll">..\References\Microsoft.Reactive.Testing.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
</Query>

/* Start 1:
 *
 * Run an Action in the background and give us an Observable that represents the
 * background task. Equivalent to (new Task(() => {...})).Start()
 *
 * This sample also demonstrates how to use First() to block on an Observable.
 */

var task = Observable.Start(() => {
    Console.WriteLine("Hello World!");

    // Do something very time-consuming here
    Thread.Sleep(1000);
    return;
});

// Wait until the task is completed
task.First();

Console.WriteLine("We're Finished!");
