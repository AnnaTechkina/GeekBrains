def get_letter(poem):
    poem = poem.split()
    list = []
    for letter in poem:
        sum_letter = 0
        for i in letter:
            if i in 'йуеыаоэяию':
                sum_letter += 1
        list.append(sum_letter)

    return len(list) == list.count(list[0])

poem = input("Введите стих: ")

if get_letter(poem):
    print('Парам пам-пам')
else:
    print('Пам парам')