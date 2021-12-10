## Create .cshtml file

1. Must have `@page` at the top
2. `@variableName` or `@(expression)` or `@method`
3. `@{ code c# here }`
4. `@for`
5. Change /FirstPage to /first-page : `@page "/first-page"`
6. Params:

- Add param abc: `@page "/first-page/{abc}"`
- Add type = int for abc: `{abc:int}`
- Not required abc: `{abc:int?}`
- Read abc, if not abc, value = 0 : `this.Request.RouteValues["abc"]??"0"` => return object
