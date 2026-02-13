
# Array Merge

You are tasked with writing a method which takes two two dimensional arrays of integers and merge them into another two dimensional array.

Example: 

Array1
```
1 2 3 3
3 2 1 6
4 5 6 1
```

Array2
```
1 9 7 2 3
0 7 8 3 2
3 8 9 7 2
```

Result:
```
1 2 3 3 1 9 7 2 3
3 2 1 6 0 7 8 3 2
4 5 6 1 3 8 9 7 2
```

It is guaranteed that the array1 and array2 will always have the same number of rows. If array1 has N rows and M columns and array2 has N rows and K columns, the resulting array will have N rows and (N + K) columns. The method signature has been provided. You just need to write your implementation for the method and we will handle the rest. 

You can assume that the two arrays will not be null, will have the same number of rows. Also, all rows and columns have been initialised.

## Running Tests

You check your implementation against the unit tests by running `dotnet test`.
