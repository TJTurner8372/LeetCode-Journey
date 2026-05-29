### 27: Remove Element

| Concept | Details |
| :--- | :--- |
| **Pattern** | **Two Pointer (Reader/Writer)**<br>One pointer iterates through the entire array reading values, while a second pointer tracks the index where the next valid element should be safely written. |
| **Time** | **$O(n)$**<br>We iterate through the array of length $n$ exactly one time. |
| **Space** | **$O(1)$**<br>The array is modified in-place without allocating any additional data structures. |
| **C# Notes** | Array mutation in C# is fast, but be careful with `IndexOutOfRangeException`. Using the counter variable as an index allows for clean, in-place overwrites without complex shifting logic. |
| **Pitfall** | Confusing the index with the value at that index. Always ensure `if` conditions are evaluating `nums[pointer]`, not just the `pointer` integer itself. |