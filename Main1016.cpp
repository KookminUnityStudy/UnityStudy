//#include <iostream>
//#include <vector>
//#include <algorithm>
//#include <functional>
//
//using namespace std;
//
//long long numList[100001];
//
//int main() {
//
//	freopen("input.txt", "r", stdin);
//	int testcase, num;
//	cin >> testcase;
//
//	while ((testcase--) != 0) {
//		long long sum[100001];
//
//		for (int i = 0; i < testcase; i++) {
//			cin >> num;
//			numList[i+1] = num;
//			sum[i] = numList[i - 1] + num;
//		}
//
//		sort(sum, sum + testcase, greater<long long>());
//
//		cout << sum[1] << endl;
//	}
//
//	return 0;
//}


/////////////////////////////////////////////
#include <iostream>
#include <vector>
using namespace std;
int arr[1000001] = { 0 };

int N, S, E;

int main() {

	freopen("input.txt", "r", stdin);
	cin >> N;


	for (int i = 1; i <= N; i++) {
		cin >> arr[i];
	}

	//check
	for (int i = 1; i <= N; i++) {
		if (i == arr[i]) {
			cout << -1 << endl;
			return 0;
		}
	}

	int cnt = 1;
	while (true) {
		vector<int> temp;


		for (int i = 1; i <= N; i++) {

		}
	}

	return 0;

}