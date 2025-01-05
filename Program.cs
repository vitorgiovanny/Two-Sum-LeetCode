
var result = TwoSum(new int[] {10, 9, 8, 2},10);

Console.WriteLine($"{result[0]}, {result[1]}");

    static int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> complements = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (complements.ContainsKey(complement)) return new int[] { complements[complement], i };

            if (!complements.ContainsKey(nums[i])) complements[nums[i]] = i;

        }
        throw new ArgumentException("Nenhum par encontrado que satisfaça a soma alvo.");
    }