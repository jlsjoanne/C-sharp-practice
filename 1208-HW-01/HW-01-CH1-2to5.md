# HW-01

## CH1 作業

---

### 第2題: 整理C#變數


| 變數型態 | 預設值 | 長度/大小 | 範圍 |
|----|----|----------------|-------------|
|bool|false|1 byte|true/false|
|byte|0|不帶±的8位整數|0-255|
|sbyte|0|帶±的8為整數|-128-127|
|short|0|帶±的16位整數|-32,768-32,767|
|ushort|0|不帶±的16位整數|0-65,535|
|int|0|帶±的32位整數|-2,147,483,648-2,147,483,647|
|uint|0|不帶±的32位整數|0-4,294,967,295|
|long|0|帶±的64位整數|-9,223,372,036,854,775,808-9,223,372,036,854,775,807|
|ulong|0|不帶±的64位整數|0-18,446,744,073,709,551,615|
|nint|0|帶±的32或64位整數|依平台決定|
|nuint|0|不帶±的32或64位整數|依平台決定|
|float|0|~6-9位數/4個位元組|$$\pm 5.0 \times10^{-45}$$-$$\pm 3.4 \times 10^{38}$$|
|double|0|~15-17位數/8個字節|$$\pm 5.0 \times 10^{-324}$$ - $$\pm 1.7 \times 10^{308}$$|
|decimal|0|28-29位數/16個字節|$$\pm 1.0 \times 10^{28} $$ - $$\pm 7.9228 \times 10^{28}$$|
|char|`\0`|UTF-16字元|U+0000至U+FFFF|

- string: class是String的物件，值為文字



### 第3題: 變數宣告

- 宣告變數: `變數型態 變數名稱;`，如: `double num;`
- 同時宣告多個變數: `變數型態 變數名稱1, 變數名稱2,...;`，如:`double num1, num2, num3;`
- 宣告變數時，同時指定變數初始值: `變數型態 變數名稱=給定初始值;`，如`double num=0;`


### 第4題 型別轉換

型別轉換有四種類別

- 隱含轉換(Implicit conversion): 不需要特殊語法，可以直接轉換，包含: 從小到大的整數轉換(如:short &rarr; int &rarr; long)、從衍生類別(derived classes)轉成基類(base classes)、範圍轉換(span conversion)。
- 明確轉換(Explicit conversion): 需要明確的轉換表達式(cast expression)，如把double型別 &rarr; int型別(如下)。

```c#
double a = 1.234;
int b;
b = (int)a;
```
- 使用者定義轉換: 使用者自行定義隱含與明確轉換的方法，用於轉換無基類衍生類別關聯性的custom types。
- 使用協助程式類別的轉換: 在不相容(noncompatible)的型別間轉換，可以使用`System.BitConverter`、`System.Convert`相關的class和`Parse`內建的數值方法(如:`Int32.Parse`)。

### 第5題 運算符用法與優先級

以下表格優先級由上到下排列

(參考資料: `https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operator-precedence`)

| 運算符 | 類別或名稱 |
|-----------|----|
|x.y, f(x), a[i], x?.y, x?[y], x++, x--, x!, new, typeof, checked, unchecked, default, nameof, delegate, sizeof, stackalloc, x->y| 主要(Primary)|
|+x, -x, !x, ~x, ++x, --x, ^x, (T)x, await, &x, *x, true and false | 單一運算(Unary) |
|x..y|範圍(Range) |
|switch, with|`switch`和`with`的表達式 |
|x * y, x / y, x % y| 乘法|
|x + y, x – y|加減法|
|x << y, x >> y, x >>> y|轉變(shift)|
|x < y, x > y, x <= y, x >= y, is, as|關係和測試類型|
|x == y, x != y |等式判斷|
|x & y|邏輯判斷:AND|
|x ^ y|邏輯判斷:XOR|
|x \| y|邏輯判斷:OR|
|x && y|條件式:AND|
|x || y|條件式:OR|
|x ?? y|NULL聯合運算元(Null-coalescing operator)|
|c ? t : f|條件運算元(Conditional operator)|
|x = y， x += y， x -= y， x *= y， x /= y， x %= y， x &= y， x \|= y， x ^<<>>= y， x = y， x >>>？？= y、=> |指派(Assignment)和lambda宣告(lambda declaration)|

