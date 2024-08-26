# ConcurrencyParallelismDemo

This project demonstrates the differences between concurrency and parallelism in .NET 6. By executing multiple tasks under different conditions, it provides a clear illustration of how these approaches impact performance.

## Project Overview

The project showcases three different approaches to executing tasks:

1. **Not Concurrent, Not Parallel**: Tasks are executed sequentially, one after another.
2. **Concurrent (Asynchronous)**: Tasks are executed concurrently, sharing CPU time using `async` and `await`.
3. **Parallel (Threads)**: Tasks are executed in parallel using multiple threads, taking advantage of multiple CPU cores.

## Technologies Used

- **.NET 6**
- **C#**
- **Task Parallel Library (TPL)**
- **Multithreading**

## How to Run

1. Clone the repository:
    ```bash
    git clone https://github.com/andersonbytech/ConcurrencyParallelismDemo.git
    ```

2. Navigate to the project directory:
    ```bash
    cd ConcurrencyParallelismDemo
    ```

3. Build and run the project:
    ```bash
    dotnet run
    ```

## Output

The program will execute 10 tasks using each of the three approaches, and you'll see the time taken for each approach printed to the console:

- **Not Concurrent, Not Parallel**: Approx. 20,098 ms
- **Concurrent (Asynchronous)**: Approx. 2,084 ms
- **Parallel (Threads)**: Approx. 2,087 ms

These results demonstrate how concurrency and parallelism can significantly reduce execution time compared to a sequential approach.

## Conclusion

This project highlights the importance of choosing the right approach for task execution, depending on the requirements of your application. Concurrency and parallelism are powerful tools, each with its own use cases.

## Credits

- **Image Inspiration**: ByteByteGo

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or comments, feel free to reach out via the repository's issues or contact me directly.
