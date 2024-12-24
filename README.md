# codebook-csharp

This repository serves as a comprehensive guide to C# programming, covering a wide range of topics from basic syntax to advanced concepts. Each chapter includes detailed explanations and code examples to help you understand and apply the concepts.

## How to Use
Each chapter is designed to be self-contained, with code examples that you can run and modify to better understand the concepts. Feel free to explore the chapters in any order that suits your learning style.

```sh
cd src/codebook
dotnet run
```

From hereon, just navigate around the menus and select to run a particular 'chapter' topic, which is nothing but a simple program to demonstrate its contents. The more interesting part is obviously the code, so focus on that, and less on the console output.

> solutions target .net9.0 and hence this codebook is written based on c# 13, so make sure to have that instealled.

## Chapters

1. Basics
    - [hello world](./src/chapters/01_basics/01_hello-world/Program.cs)
    - [variables](./src/chapters/01_basics/02_variables/Program.cs)
    - [constants](./src/chapters/01_basics/03_constants/Program.cs)
    - [primitives](./src/chapters/01_basics/04_primitives/Program.cs)
    - [nullables](./src/chapters/01_basics/05_nullables/Program.cs)
    - [type inference](./src/chapters/01_basics/06_type-inference/Program.cs)
2. Operators
    - [arithmetic](./src/chapters/02_operators/01_arithmetic-operators/Program.cs)
    - [comparison](./src/chapters/02_operators/02_comparison-operators/Program.cs)
    - [logical](./src/chapters/02_operators/03_logical-operators/Program.cs)
    - [bitwise](./src/chapters/02_operators/04_bitwise-operators/Program.cs)
    - [coalescing](./src/chapters/02_operators/05_coalescing/Program.cs)
3. Flow Control
    - [conditional statements](./src/chapters/03_flow-controls/01_conditional-statements/Program.cs)
    - [switch statements](./src/chapters/03_flow-controls/02_switch-statements/Program.cs)
4. Loops
    - [for](./src/chapters/04_loops/01_for-loop/Program.cs)
    - [while](./src/chapters/04_loops/02_while-loop/Program.cs)
    - [foreach](./src/chapters/04_loops/03_foreach-loop/Program.cs)
5. Exceptions
    - [throwing](./src/chapters/05_exceptions/01_throw-exceptions/Program.cs)
    - [handling](./src/chapters/05_exceptions/02_handle-exceptions/Program.cs)
6. Methods
    - [definition](./src/chapters/06_methods/01_methods-definition/Program.cs)
    - [overload](./src/chapters/06_methods/02_methods-overload/Program.cs)
    - [nesting](./src/chapters/06_methods/03_methods-nested/Program.cs)
    - [closures](./src/chapters/06_methods/04_methods-closure/Program.cs)
    - [extensions](./src/chapters/06_methods/05_methods-extension/Program.cs)
    - [top level](./src/chapters/06_methods/06_top-level/Program.cs)
7. Class
    - [definition](./src/chapters/07_class/01_class-definition/Program.cs)
    - [fields](./src/chapters/07_class/02_class-fields/Program.cs)
    - [properites](./src/chapters/07_class/03_class-properties/Program.cs)
    - [methods](./src/chapters/07_class/04_class-methods/Program.cs)
    - [parameterized constructors](./src/chapters/07_class/05_constructors-parameterized/Program.cs)
    - [static constructors](./src/chapters/07_class/06_constructors-static/Program.cs)
    - [finalizers](./src/chapters/07_class/07_finalizers/Program.cs)
    - [inheritance](./src/chapters/07_class/08_inheritance/Program.cs)
    - [overriding](./src/chapters/07_class/09_overriding/Program.cs)
    - [interfaces](./src/chapters/07_class/10_interfaces/Program.cs)
    - [abstraction](./src/chapters/07_class/11_abstract/Program.cs)
    - [static](./src/chapters/07_class/12_static/Program.cs)
    - [sealed](//src/chapters/07_class/13_sealed/Program.cs)
8. OOP
    - [access modifiers](./src/chapters/08_oop/01_access-modifiers/Program.cs)
    - [encapsulation](./src/chapters/08_oop/02_encapsulation/Program.cs)
    - [pattern matching](./src/chapters/08_oop/03_pattern-match/Program.cs)
    - [polymorphism](./src/chapters/08_oop/04_polymorphism/Program.cs)
    - [struct](./src/chapters/08_oop/05_structs/Program.cs)
    - [generics](./src/chapters/08_oop/06_generics/Program.cs)
    - [activator](./src/chapters/08_oop/07_activator/Program.cs)
    - [immutability](./src/chapters/08_oop/08_immutability/Program.cs)
    - [record](./src/chapters/08_oop/09_record/Program.cs)
    - [init only](./src/chapters/08_oop/10_init-only/Program.cs)
    - [covariant returns](./src/chapters/08_oop/11_covariant-returns/Program.cs)
    - [target types](./src/chapters/08_oop/12_target-types/Program.cs)
9. Collections
    - [array](./src/chapters/09_collections/01_arrays/Program.cs)
    - [string](./src/chapters/09_collections/02_strings/Program.cs)
    - [list](./src/chapters/09_collections/03_lists/Program.cs)
    - [dictionary](./src/chapters/09_collections/04_dictionaries/Program.cs)
    - [linq](./src/chapters/09_collections/05_linq/Program.cs)
    - [enumerations](./src/chapters/09_collections/06_enumerations/Program.cs)
    - [tuple](./src/chapters/09_collections/07_tuples/Program.cs)
10. Memory
    - [types](./src/chapters/10_memory/01_types/Program.cs)
    - [references](./src/chapters/10_memory/02_reference/Program.cs)
    - [allocation](./src/chapters/10_memory/03_allocation/Program.cs)
    - [nullable](./src/chapters/10_memory/04_nullable/Program.cs)
    - [garbage collection](./src/chapters/10_memory/05_gc/Program.cs)
    - [management](./src/chapters/10_memory/06_management/Program.cs)
11. I/O
    - [read & write](./src/chapters/11_io/01_read-write/Program.cs)
    - [streams](./src/chapters/11_io/02_streams/Program.cs)
    - [serialization](./src/chapters/11_io/03_serialization/Program.cs)
12. Functions
    - [delegates](./src/chapters/12_func/01_delegates/Program.cs)
    - [lambda](./src/chapters/12_func/02_lambda/Program.cs)
    - [anonymous](./src/chapters/12_func/03_anonymous/Program.cs)
    - [func](./src/chapters/12_func/04_func/Program.cs)
    - [action](./src/chapters/12_func/05_action/Program.cs)
    - [predicate](./src/chapters/12_func/06_predicate/Program.cs)
13. Asynchronicity
    - [awaiting](./src/chapters/13_asynchronicity/01_awaiting/Program.cs)
    - [tasks](./src/chapters/13_asynchronicity/02_tasks/Program.cs)
    - [threading](./src/chapters/13_asynchronicity/03_threading/Program.cs)
    - [thread safety](./src/chapters/13_asynchronicity/04_thread-safety/Program.cs)
    - [parallel](./src/chapters/13_asynchronicity/05_parallel/Program.cs)
14. Meta
    - [attribute](./src/chapters/14_meta/01_attribute/Program.cs)
    - [reflection](./src/chapters/14_meta/02_reflection/Program.cs)
    - [dynamic](./src/chapters/14_meta/03_dynamic/Program.cs)
    - [expression](./src/chapters/14_meta/04_expression/Program.cs)
    - [preprocessor directives](./src/chapters/14_meta/05_preprocessor-directives/Program.cs)
    - [debug](./src/chapters/14_meta/06_debug/Program.cs)
