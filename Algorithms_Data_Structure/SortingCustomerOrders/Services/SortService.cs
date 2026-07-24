using SortingCustomerOrders.Models;

namespace SortingCustomerOrders.Services
{
    public class SortService
    {
        // Bubble Sort
        public void BubbleSort(Order[] orders)
        {
            int n = orders.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                    {
                        Order temp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = temp;
                    }
                }
            }
        }

        // Quick Sort
        public void QuickSort(Order[] orders, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(orders, low, high);

                QuickSort(orders, low, pi - 1);
                QuickSort(orders, pi + 1, high);
            }
        }

        private int Partition(Order[] orders, int low, int high)
        {
            decimal pivot = orders[high].TotalPrice;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (orders[j].TotalPrice < pivot)
                {
                    i++;

                    Order temp = orders[i];
                    orders[i] = orders[j];
                    orders[j] = temp;
                }
            }

            Order temp1 = orders[i + 1];
            orders[i + 1] = orders[high];
            orders[high] = temp1;

            return i + 1;
        }

        public void Display(Order[] orders)
        {
            Console.WriteLine();

            foreach (Order order in orders)
            {
                Console.WriteLine(
                    $"{order.OrderId}  {order.CustomerName}  ₹{order.TotalPrice}");
            }
        }
    }
}