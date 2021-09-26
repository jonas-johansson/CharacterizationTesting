# Characterization Testing

This is a C# project that's intentionally ugly and overly complex. It can be used to practice your skills for understanding code and cleaning it up.

You should imagine that the code is currently in use by people, so it's important that we don't accidentally break its current behavior.

## Steps

### Look around
- Have a look at the code. Ugly? Yeah!
- Go to `SomeLegacyClassTests.cs`.

### Explore by writing tests

- Make a new test (copy the test in `SomeLegacyClassTests.cs`) and call it `SomeTest`.
- Use your code editor to explore the methods in `SomeLegacyClass`.
- Pick one of the methods, and call it with some parameters.
- Add `Assert.AreEqual(0, x.TheMethodYouPicked(someValueThatYouPick, anotherValueThatYouPick));`.
- Run the tests.
- If the test failed, change the first 0 there to be the value you actually got. This locks down the current behavior.
- Keep adding multiple tests for each method.
- You might start building some intuition of what the methods do, and if you don't you at least have some guard rails in place.
- What you've been doing now is characterization testing.

### Refactor
- Now you should have a bunch of tests in place.
- Go ahead and change the name of the methods if you already have a better name for them.
- Clean up a piece of the code.
- Run the tests and make sure that they pass.
- Rinse and repeat until you're happy with it.

### Extend
- Add a new fitting method to SomeLegacyClass, with some tests.