# Auror Algorithm Test

This project contains 2 project.
1. AurorAlgorithmTest - It contains the solution for below case

This is a quick coding exercise to help us understand how you approach a simple programming problem. Provide a simple, readable, but fully correct solution to the following spec:

We'd like you to implement a string interpolation algorithm. It's likely going to be used to format simple messages to be sent to users. It should take a string and a dictionary of values. It will return the input string, but with the dictionary values subsituted into the [] delimited tokens, for example:

```    
    // values from the dictionary get substituted into square brackets
    Assert.Equal("Hello Jim", Interpolate("Hello [name]", new Dictionary<string, string>{{"name", "Jim"}}));
    // escape the square brackets by doubling them:
    Assert.Equal("Hello Jim [author]", Interpolate("Hello [name] [[author]]", new Dictionary<string, string>{{"name", "Jim"}}));
```

2. AurorAlgorithmUnitTest - It contains the unit test cases for the solution under AurorAlgorithmTest

 

