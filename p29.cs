// Multidimensional Arrays
int[,] arr2d; // two-dimensional array
int[,,] arr3d; // three-dimensional array
int[,,,] arr4d; // four-dimensional array
int[,,,,] arr5d; // five-dimensional array

// two-dimensional Array
int[,] arr2d = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

// or
int[,] arr2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

// Access two-dimensional Array
int[,] arr2d = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

arr2d[0, 0]; //returns 1
arr2d[0, 1]; //returns 2
arr2d[1, 0]; //returns 3
arr2d[1, 1]; //returns 4
arr2d[2, 0]; //returns 5
arr2d[2, 1]; //returns 6

//arr2d[3, 0]; //throws run-time error as there is no 4th row

// Three-dimensional Array
int[,,] arr3d1 = new int[1, 2, 2] { { { 1, 2 }, { 3, 4 } } };

int[,,] arr3d2 = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

int[,,] arr3d3 = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

arr3d2[0, 0, 0]; // returns 1
arr3d2[0, 0, 1]; // returns 2
arr3d2[0, 1, 0]; // returns 3
arr3d2[0, 1, 1]; // returns 4
arr3d2[1, 0, 0]; // returns 5
arr3d2[1, 0, 1]; // returns 6
arr3d2[1, 1, 0]; // returns 7
arr3d2[1, 1, 1]; // returns 8

// Four-dimensional Array
int[,,,] arr4d1 = new int[1, 1, 2, 2] { { { { 1, 2 }, { 3, 4 } } } };

arr4d1[0, 0, 0, 0]; // returns 1
arr4d1[0, 0, 0, 1]; // returns 2
arr4d1[0, 0, 1, 0]; // returns 3
arr4d1[0, 0, 1, 1]; // returns 4

int[,,,] arr4d2 = new int[1, 2, 2, 2] { { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } } };

arr4d2[0, 0, 0, 0]; // returns 1
arr4d2[0, 0, 0, 1]; // returns 2
arr4d2[0, 0, 1, 0]; // returns 3
arr4d2[0, 0, 1, 1]; // returns 4
arr4d2[0, 1, 0, 0]; // returns 5
arr4d2[0, 1, 0, 1]; // returns 6
arr4d2[0, 1, 1, 0]; // returns 7
arr4d2[0, 1, 1, 1]; // returns 8


