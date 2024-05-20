bool FindDuplicate(int[] nums)
{
    var set = new HashSet<int>();
    foreach (var num in nums)
    {
        if (set.Contains(num))
        {
            return true;
        }
        set.Add(num);
    }
    return false;
}
Console.WriteLine(FindDuplicate(new int[] { 1, 2, 3, 1 })); // true
                                                            //C#'ta HashSet nedir?
                                                            //HashSet, bir koleksiyonun benzersiz elemanlarını depolamak için kullanılan bir veri yapısıdır.

//FindDuplicate fonksiyonu için başka bir çözüm

bool FindDuplicate2(int[] nums)
{
    Array.Sort(nums);
    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == nums[i - 1])
        {
            return true;
        }
    }
    return false;
}
//FindDuplicate fonksiyonu için en kısa çözüm daha az yer kaplar.
bool FindDuplicate3(int[] nums) => nums.Length != nums.Distinct().Count();
