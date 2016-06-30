
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

	cout << 3 << endl;

	return 0;

}