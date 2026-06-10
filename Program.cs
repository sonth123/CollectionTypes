#region BaiTap1
// Tính tổng các số trong 1 mảng
int[] lstNumber = {20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20};
int sum = 0;
foreach (int number in lstNumber)
{
    sum += number;
}
Console.WriteLine("Tổng các số trong danh sách: " + sum);

#endregion

#region BaiTap2
// Tìm 2 số trong 1 mảng sao cho tổng bằng 1 giá trị cho trước
int[] lstNumber2 = [2, 7, 11, 15];
int target = 9;
for (int i = 0; i < lstNumber2.Length; i++)
{
    for (int j = i + 1; j < lstNumber2.Length; j++)
    {
        if (lstNumber2[i] + lstNumber2[j] == target)
        {
            Console.WriteLine("Hai số có tổng bằng " + target + " là: " + lstNumber2[i] + " và " + lstNumber2[j]);
        }
    }
}
#endregion

#region BaiTap3
// Loại bỏ các phần tử trùng lặp từ 1 mảng đã sắp xếp và trả về chiều dài của mảng mới
int[] lstNumber3 = [1, 1, 2, 2, 2, 3, 4, 4, 5];
int soKhongTrungLap = 0;
for (int i = 0; i < lstNumber3.Length; i++)
{
    if (i == 0 || lstNumber3[i] != lstNumber3[i - 1])
    {
        lstNumber3[soKhongTrungLap] = lstNumber3[i];
        soKhongTrungLap++;
    }
}
Console.WriteLine("Số phần tử không trùng lặp: " + soKhongTrungLap);
#endregion

#region BaiTap4
// Tìm k phần tử xuất hiện nhiều nhất trong 1 mảng và trả về chúng dưới dạng danh sách. 
// Nếu có nhiều phần tử có cùng tần số xuất hiện, trả về bất kỳ trong số chúng.
int[] lstNumber4 = [1, 1, 1, 2, 2, 3];
int k = 2;
var xuatHienNhieuNhat = lstNumber4.GroupBy(x => x)
    .OrderByDescending(g => g.Count())
    .Take(k)
    .Select(g => g.Key)
    .ToList();

Console.WriteLine($"{k} phần tử xuất hiện nhiều nhất: " + string.Join(", ", xuatHienNhieuNhat));
#endregion

#region BaiTap5
// Cho 1 mảng prices,mỗi phần tử của nó đại diện cho giá cổ phiếu trong một ngày. Bạn chỉ được mua cổ phiếu 
// 1 lần và bán cổ phiếu 1 lần. Hãy tìm giá trị lớn nhất bạn có thể có từ việc mua và bán cổ phiếu.
int[] prices = [7, 1, 5, 3, 6, 4];
int maxProfit = 0;
int minPrice = int.MaxValue;
foreach (int price in prices)
{
    if (price < minPrice)
    {
        minPrice = price;
    }
    else if (price - minPrice > maxProfit)
    {
        maxProfit = price - minPrice;
    }
}
Console.WriteLine("Giá trị lớn nhất: " + maxProfit);
#endregion