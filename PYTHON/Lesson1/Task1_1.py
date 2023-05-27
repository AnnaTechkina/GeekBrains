#Найдите сумму цифр трехзначного числа.

number = int(input('Введите трёхзначное число: '))
sum = 0

while number > 0:
    sum = sum + (number % 10)
    number //= 10

print(sum)