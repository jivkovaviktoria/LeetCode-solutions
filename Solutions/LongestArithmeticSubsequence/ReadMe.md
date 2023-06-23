<h1 align="center">1027. Longest Arithmetic Subsequence</h1>

Given an array `nums` of integers, return the length of the longest arithmetic subsequence in `nums`.

**Note that:**

 - A subsequence is an array that can be derived from another array by deleting some or no elements without changing the order of the remaining elements.
 - A sequence seq is arithmetic if `seq[i + 1] - seq[i]` are all the same value `(for 0 <= i < seq.length - 1)`.

<br>

***Solution explanation:***

We initialize variable `ans = 1`. There we will store the longest arithmetic subsequence found so far.
Then we create array of `Dictionary<int, int>`. <br>
We iterate over each element from `nums`. <br>
Let's say the current element is `nums[i]`. We create a new empty `Dictionary<int, int>` and asign
it to `map[i]`. Inside the second loop we iterate over all of the elements before `nums[i]`.
We find the difference (`diff`) between `nums[i]` and `nums[j]`. We check if the dictionary `map[j]`, which represents
the the element in `nums` at index `j`, contains a key equal to `diff`. If it does, it means that
we already seen an arithmetic subsequence with the same difference - `diff`, so we add 1 to the value of 
`map[j][diff]` and store it as the value of `map[i][diff]`. If map[j] doesn't contain the key diff, it means we haven't seen an arithmetic subsequence with that difference before. So we initialize map[i][diff] to 1, indicating that we have found a new subsequence of length 1 ending at nums[i] with the difference diff.
After updating map[i][diff], we compare its value with the current value of ans (the length of the longest arithmetic subsequence found so far) using the Math.Max function. We update ans to the maximum value between ans and map[i][diff].

After finishing the inner loop, we move to the next iteration of the outer loop and repeat the process for the next element in nums.