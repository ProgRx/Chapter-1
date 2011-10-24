<Query Kind="Statements">
  <Reference Relative="..\References\System.Reactive.dll">..\References\System.Reactive.dll</Reference>
  <Reference Relative="..\References\Microsoft.Reactive.Testing.dll">..\References\Microsoft.Reactive.Testing.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
</Query>

/* Return 2:
 *
 * Show that Return Completes after returning its one value
 */

// Materialize lets us see the OnComplete, which normally isn't part of the
// values returned in the stream.
var input = Observable.Return(42).Materialize();

input.Dump();
