#Петя, Катя и Сережа делают из бумаги журавликов. Вместе они сделали S журавликов. Сколько журавликов сделал каждый ребенок, 
#если известно, что Петя и Сережа сделали одинаковое количество журавликов, а Катя сделала в два раза больше журавликов, 
#чем Петя и Сережа вместе?

s = int(input("Количество журавликов:  "))

Pety = int(s / 6)
Serega = Pety
Katy = int((Pety + Serega) * 2)

print(s, Pety, Katy, Serega)