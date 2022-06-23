fibo = [1,1]
i = 0
num = int(input("Digite um número: "))

while num > len(fibo):
	fibo.append(fibo[i] + fibo[i+1])
	i+=1

print ('Fibonacci(%d): %d' %(num,fibo[num-1]))