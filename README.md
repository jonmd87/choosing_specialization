**Итоговая проверочная работа.**
**Задание:**
    _Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно._

    *Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:*
_**1. Создать репозиторий на GitHub**_

_**2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если выnвыделяете ее в отдельный метод)**_

_**3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)**_

_**4. Написать программу, решающую поставленную задачу**_ 

_**5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залитоодним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)**_

_Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами._

**Примеры:**
* ["hello", "2", "world", ":-)"] => ["2", ":-)"]
* ["1234", "1567", "-2", "computer science"] → ["-2"]
* ["Russia", "Denmark", "Kazan"] - []

## Описание Решения

** 1. Генерируем случайное число от 1 до 9
** 2. Создаем массив строк, длина массива наше случайное число
** 3. Просим пользователя ввести с клавиатуры слова(строку), строка не должна быть пустой
** 4. Выводим на экран наш массив строк
** 5. Передаем массив строк в метод который, подсчитывает количество слов, длина которых меньше или равна 3.
    * метод проходит по массиву и подсчитывает количество слов меньше или равна 3
    * затем создаем новый массив коротих строк
    * проходим еще раз первоначальный массив и если слово меньше или равна 3 записываем его в массив коротких слов
** 6. выводим на экран массив коротких строк


#### [Блок Схемапросто картинка](recomends.png)
