# Handwriting Recognizer
This is a desktop application that allows users to upload images of 28x28 handwritten digits and receive real-time predictions using a Convolutional Neural Network (CNN) trained on the MNIST dataset. Built with C# WPF for the frontend and Python for the machine learning backend.

## 🔗 Live Demo
Since this is a desktop application, a live demo isn't available. However, you can clone the repository and run it locally.

## 🛠 How It's Made
Tech Stack:

Frontend: C#, WPF, XAML

Backend: Python, PyTorch

Machine Learning: CNN trained on MNIST dataset

Integration: ProcessStartInfo for inter-process communication between C# and Python

Key Features:

User-friendly interface for uploading and previewing images.

Real-time digit prediction with 99% accuracy on the MNIST validation set.

Asynchronous processing to ensure a responsive UI during prediction.

## 🚀 Optimizations
Implemented asynchronous calls to the Python backend to prevent UI freezing during predictions.

Utilized a custom CNN architecture optimized for the MNIST dataset, achieving high accuracy with minimal computational resources.

Streamlined the inter-process communication between C# and Python for efficient data handling.

## 📚 Lessons Learned
Gained experience in integrating machine learning models into desktop applications.

Learned the intricacies of inter-process communication and managing asynchronous operations in C#.

Understood the importance of user experience in application responsiveness and feedback.

## 📸 Screenshots
[img](https://pbs.twimg.com/media/Gp9fdZjXoAA853h?format=png&name=900x900)

## 📄 License
This project is licensed under the MIT License.
