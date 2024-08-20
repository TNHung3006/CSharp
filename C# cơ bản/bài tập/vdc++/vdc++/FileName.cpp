#include <iostream>
using namespace std;
int main() {
    int n;
    cout << "Nhap so luong phan tu cua mang : "; cin >> n;
    int* array = new int[n];

    cout << "Nhap Mang : " << endl;
    for (int i = 0; i < n; i++)
        cin >> array[i];

    int k = 0, s = 0;
    for (int i = 0; i < n; i++)
        if (array[i]) k++;
    int index = k;

    for (int i = 0; i < k; i++)
    {
        if (array[i] == 0){ 
            s++;
            while (!array[index])
            {
                index++;
            }
            swap(array[i], array[index]);
        }
    }
    cout << "So lan hoan doi toi thieu la : " << k - s << endl;
    cout << "Mang sau khi hoan doi la :" << endl;
    for (int i = 0; i < n; i++)
        cout << array[i] << " ";


    return 0;
}