import random

A = int(input())
B = int(input())
N = int(input())

arr = []

for i in range(N):
    arr.append(random.randint(A, B))
    print(arr[i], end = " ")

counter = 0
for i in range(N):
    digit = str(arr[i])[1]
    if (int(digit) % 2 == 1):
        counter += 1

print("\n%d" % counter)