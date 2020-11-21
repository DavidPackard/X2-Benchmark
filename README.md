# X2 Benchmark
This here is a very simple PC benchmarking program based around the processor's ability to do math quickly. It measures how quickly it can multiply a number by 2 (hence the name "X2"). This is currently version 1, and it should be updated soon enough... hopefully.

> Make sure that you have a windows PC, it hasn't been tested on anything below windows 10 but please feel free to try

How to Install:
1) Make a program folder where the program will be stored on your PC
2) Extract the zip file into the folder and make sure that there is:
     - 1x 2XBenchmark.exe Executable Program
     - 6x differently named batch files, their names are listed below
          => bench10.bat
          => bench50.bat
          => bench100.bat
          => bench500.bat
          => bench1000.bat
          => bench10000.bat
3) Make sure that all files listed above are in the same folder
4) You're ready to benchmark your PC
Keep in mind that the program should also be able to be installed as a portable program on a USB if you follow the steps above

# How to use the Benchmark
Once you have run 2XBenchmark.exe, you will see 6 different options. Each of these options are different lengths of benchmark, and will each take longer to complete.

Once you have selected the option that you would like to use as a benchmark, click on it, and check the taskbar of your computer for a new program that has opened, this is the benchmark running.
> The Benchmark utilises Windows CMD, and it therefore doesn't have a program logo. This should make it easier to spot.
You will need to click the newly opened window, and will have to wait for the benchmark to complete. Once it is complete it will give you your result at the bottom of the window. That is the time that it took for the benchmark to complete, and that will be your score.
# Scoring
The scoring system is pretty easy to understand. 
The benchmarks are scored by the time that it takes your computer to execute the benchmark.
A higher time, means a slower computer, which is bad.
A lower time means a faster computer, which is good.

# Branches and Releases
As you'll soon notice, there are several branches and releases for this repo.
Any releases are stable, and should work fine. Please feel free to let me know if anything goes wrong, and I'll fix it in the next release.
The branches that are marked as STABLE are the source code for the releases, and usually contain the release .zip file somewhere in it. The Work In Progress branch however, is the unstable pre-release testing environment that I use as a base to code the newer versions, eventually once this branch becomes stable, it will become its own STABLE branch and Release.
