User = input('Enter your name and profession: ')
with open('Employees.txt', 'a+') as file:
    file.write(User)
    for check_for_duplicates in file.readlines():
        if check_for_duplicates == User:
            print()

