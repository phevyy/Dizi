# 🔗 Singly Linked List Console Application

This project is a C# implementation of a **Singly Linked List** data structure from scratch. Unlike standard Arrays or `List<T>`, this application manages memory dynamically using Nodes and Pointers, allowing users to manually add, remove, and visualize data through a console interface.

## 📝 Description

A Linked List is a linear data structure where elements are not stored at contiguous memory locations. Instead, each element (Node) points to the next one. This project demonstrates:
* Creating a custom `Node` class.
* Managing links between nodes (`Next` pointers).
* Traversing a list for insertion and deletion.
* Handling edge cases (e.g., removing the head node or an empty list).

## 📂 Code Structure

The project consists of three main components:

| Class Name | Responsibility |
| :--- | :--- |
| **`Node`** | Represents a single element containing integer data and a reference (pointer) to the next node. |
| **`LinkedList`** | Contains the logic for the list operations (Add, Remove, Print) and manages the `Head` reference. |
| **`Program`** | Provides the user interface (Menu) to interact with the list. |

## 🚀 Features

* **Add Last:** Appends a new integer to the end of the list.
* **Remove Item:** Searches for a specific value and removes the first occurrence from the list.
* **Print List:** Visualizes the current state of the list in a connected format (e.g., `5 > 10 > null`).
* **Interactive Menu:** A loop-based menu system for continuous testing.

## ⚙️ Logic Explanation

### 1. Adding a Node (`AddLast`)
If the list is empty, the new node becomes the **Head**. Otherwise, the program traverses the list starting from the Head until it finds the last node (where `Next` is null) and links the new node there.

### 2. Removing a Node (`Remove`)
* **Case 1 (Head):** If the value to be removed is at the Head, the Head pointer is moved to the next node.
* **Case 2 (Middle/End):** The program iterates through the list to find the node *before* the target node and changes its `Next` pointer to skip the target.

## 💻 Usage Example

```text
Yapmak istediğiniz işlemi seçin:
1. Eleman ekleme (sona)
2. Eleman çıkarma
3. Listeyi yazdırma
4. Çıkış

Seçiminiz: 1
Lütfen eklenecek sayıyı girin: 10
10 sayısı listeye eklendi.

Seçiminiz: 1
Lütfen eklenecek sayıyı girin: 20
20 sayısı listeye eklendi.

Seçiminiz: 3
Liste durumu:
10 > 20 > null

Seçiminiz: 2
Lütfen çıkarılacak sayıyı giriniz: 10

Seçiminiz: 3
Liste durumu:
20 > null
```

## 🛠️ How to Run

1. Open the project in your preferred C# IDE (Visual Studio, VS Code, or Rider).

2. Compile and run Program.cs.

3. Follow the on-screen menu instructions.

## ⚠️ Requirements
- .NET SDK installed.
