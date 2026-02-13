namespace ArrayMerge.Test;

public class ArrayMergeTest
{
    [Fact]
	public void TestSimple() {
		int[][] a = { 
				new int[] {1, 2, 3}, 
				new int[] {3, 2, 1}, 
				new int[] {2, 1, 3}
		};
		int[][] b = {
				new int[] {1, 2, 3}, 
				new int[] {3, 2, 1}, 
				new int[] {2, 1, 3}
		};
		int[][] c = {
				new int[] {1, 2, 3, 1, 2, 3}, 
				new int[] {3, 2, 1, 3, 2, 1}, 
				new int[] {2, 1, 3, 2, 1, 3}
		};
		int[][] result = ArrayMerge.MergeArrays(a, b);
		if(result.Length != c.Length){
			Assert.Fail("Wrong number of rows.");
		}
		if(result[0].Length != c[0].Length)
			Assert.Fail("Wrong number of columns.");
		for(int i = 0; i < result.Length; i++){
			for(int j = 0; j < result[0].Length; j++){
				if(c[i][j] != result[i][j]){
					Assert.Fail("Incorrect element in the resulting array.");
				}
			}
		}
	}
    [Fact]
	public void TestDifferentDimentions() {
		int[][] a = { 
				new int[] {1, 2, 3, 4}, 
				new int[] {3, 2, 1, 5}, 
				new int[] {2, 1, 3, 6}
		};
		int[][] b = {
				new int[] {1, 2, 3, 9, 8}, 
				new int[] {3, 2, 1, 6, 5}, 
				new int[] {2, 1, 3, 3, 2}
		};
		int[][] c = {
				new int[] {1, 2, 3, 4, 1, 2, 3, 9, 8}, 
				new int[] {3, 2, 1, 5, 3, 2, 1, 6, 5}, 
				new int[] {2, 1, 3, 6, 2, 1, 3, 3, 2}
		};
		int[][] result = ArrayMerge.MergeArrays(a, b);
		if(result.Length != c.Length){
			Assert.Fail("Wrong number of rows.");
		}
		if(result[0].Length != c[0].Length)
			Assert.Fail("Wrong number of columns.");
		for(int i = 0; i < result.Length; i++){
			for(int j = 0; j < result[0].Length; j++){
				if(c[i][j] != result[i][j]){
					Assert.Fail("Incorrect element in the resulting array.");
				}
			}
		}
	}

    /*
    [Fact]
	public void TestLongArray() {
		int[][] a = new int[1][10000];
		for(int i = 0; i < 10000; i++){
			a[0][i] = i;
		}
		int[][] b = new int[1][50000];
		for(int i = 10000; i < 60000; i++){
			b[0][i - 10000] = i;
		}
		int[][] c = new int[1][60000];
		for(int i = 0; i < 60000; i++){
			c[0][i] = i;
		}
		int[][] result = ArrayMerge.MergeArrays(a, b);
		if(result.Length != c.Length){
			Assert.Fail("Wrong number of rows.");
		}
		if(result[0].Length != c[0].Length)
			Assert.Fail("Wrong number of columns.");
		for(int i = 0; i < result.Length; i++){
			for(int j = 0; j < result[0].Length; j++){
				if(c[i][j] != result[i][j]){
					Assert.Fail("Incorrect element in the resulting array.");
				}
			}
		}
	}
    
    [Fact]
	public void TestTallArray() {
		int[][] a = new int[10000][1];
		for(int i = 0; i < 10000; i++){
			a[i][0] = i;
		}
		int[][] b = new int[10000][1];
		for(int i = 0; i < 10000; i++){
			b[i][0] = i;
		}
		int[][] c = new int[10000][2];
		for(int i = 0; i < 10000; i++){
			for(int j = 0; j < 2; j++){
				c[i][j] = i;
			}
		}
		int[][] result = ArrayMerge.MergeArrays(a, b);
		if(result.Length != c.Length){
			Assert.Fail("Wrong number of rows.");
		}
		if(result[0].Length != c[0].Length)
			Assert.Fail("Wrong number of columns.");
		for(int i = 0; i < result.Length; i++){
			for(int j = 0; j < result[0].Length; j++){
				if(c[i][j] != result[i][j]){
					Assert.Fail("Incorrect element in the resulting array.");
				}
			}
		}
	}*/
}
