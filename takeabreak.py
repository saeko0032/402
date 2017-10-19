import webbrowser
import time
break_count = 0
total_breaks = 3
print("This program started on ",time.ctime())
while(break_count < total_breaks):
    time.sleep(5)
    webbrowser.open("https://www.youtube.com/watch?v=fwK7ggA3-bU&list=RDGMEMQ1dJ7wXfLlqCjwV0xfSNbAVMPIh2xe4jnpk&index=7")
    break_count += 1
