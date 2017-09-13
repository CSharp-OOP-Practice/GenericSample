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