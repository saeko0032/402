import turtle
window = turtle.Screen()
window.bgcolor("red")

fig = turtle.Turtle()
fig.shape("circle")
fig.color("white")
fig.speed(12)
def draw_square():


    fig.forward(200)
    fig.right(90)
    fig.forward(200)
    fig.right(90)
    fig.forward(200)
    fig.right(90)
    fig.forward(200)
    fig.right(90)

    fig.right(10)
    
    #fig2 = turtle.Turtle()
    #fig2.shape("arrow")
    #fig2.circle(100)

#start = 0
#end = 36

#while start < end:
#    draw_square()
#    start += 1
for i in range(0, 36):
    draw_square()
