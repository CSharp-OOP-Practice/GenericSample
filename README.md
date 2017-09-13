[TOC]

---

## Generics

### System.Collections.Generic

*加入泛型讓世界變得更美好*

目前在 .NET 可以找到通用的 collection 方法都在 System.Collection.Generic。

####<T>

參閱 ObjectList，.NET 1.0 以前沒有泛型，所以想達成泛型化的目的，就必須將型別來回轉換成通用基底型別 Object。

加入泛型改寫 ObjectList 範例，可參閱 GenericList<T>。

#### <TKey, Tvalue>

像是 System.Collections.Generic.Dictionary 用來裝索引鍵和值的集合。

基本範例 GenericDictionary<Tkey, TValue>，僅重現 Dictionary 的 Add 方法殼。

### Other 小技巧

#### where

泛型用 <T>，.NET 預設當它為 object，這時可用 where 加上 T 的限制條件，指定 T 是什麼。

基本範例可參閱：Utilities<T>、DiscountCalculator<TProduct>

```c#
// where T : IComparable
// where T : 自定類別名稱
// where T : struct
// where T : class
// where T : new()
```

##### where T : struct

想預設 value type 的值，可用 defaut 關鍵字。

簡單自己寫一個基本範例可參閱 Nullable<T>。

.NET 自己有 System.Nullable<T>

##### where T : IComparable 或 自定類別名稱

用在當有需要在方法內傳入的 T 參數屬性。

基本範例可參考 DiscountCalculator<TProduct>

PS：無法在方法裡面直接 new T()

##### where T : new()

當需要在方法裡面 new T()，那就必須使用 where T : new()，否則 compile 不知道 T 是誰，無法 new。

基本範例可參考 Utilities 裡面的 DoSomething(T)