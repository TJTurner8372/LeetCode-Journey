### 88: Merge Sorted Array

| Concept | Details |
| :--- | :--- |
| **Pattern** | **Two Pointers (Iterating Backwards)**<br>We use three pointers to track the ends of the valid data in both arrays and the end of the buffer in `nums1`, filling `nums1` from right-to-left to avoid overwriting unmerged data. |
| **Time** | **$O(m+n)$**<br>We iterate through the elements of both arrays exactly once. |
| **Space** | **$O(1)$**<br>We modify `nums1` entirely in-place without allocating any extra data structures. |
| **C# Notes** | C# arrays are reference types. When passing `nums1` into a `void` method, modifying elements via their index directly mutates the state that xUnit (and LeetCode) will assert against. Beware of LINQ methods like `Order()` which create new collections instead of modifying in-place. |
| **Pitfall** | Always differentiate between an *index* (the pointer variable) and the *value* at that index (the array lookup). Leftover elements in the target array (`nums1`) do not need to be moved if the source array (`nums2`) is exhausted first. |