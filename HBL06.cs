//1a
// The for loop iterates through all elements in birdName, even after finding the desired bird. This makes it inefficient, as it continues checking when it is no longer necessary.
//1b
'''
  count = 0
birdFound = False

while count < 8 AND NOT birdFound do
    if bird == birdName[count] then
        birdFound = True
        birdsObserved = input("Enter number of birds observed: ")
        birdCount[count] = birdCount[count] + birdsObserved
    endif
    count = count + 1
endwhile
'''
//2
'''
totalWeight = 0
numberOfBabies = 100

for i = 0 to numberOfBabies - 1 do
    totalWeight = totalWeight + weight[i]
endfor

averageWeight = totalWeight / numberOfBabies
belowCount = 0
belowTotal = 0

for i = 0 to numberOfBabies - 1 do
    if weight[i] < averageWeight - 500 then
        belowCount = belowCount + 1
        belowTotal = belowTotal + weight[i]
    endif
endfor

if belowCount > 0 then
    belowAverageWeight = belowTotal / belowCount
    print("Number of babies below 500 grams of average: ", belowCount)
    print("Average weight of these babies: ", belowAverageWeight)
else
    print("No babies are more than 500 grams below the average.")
endif
'''
//3
          	A1	A2	A3
Student 1	  7 	8 	6
Student 2 	5 	9 	0
Student 3	  10	7	  8
Student 4	  6	  0  	4
Student 5	  8	  7  	9

'''
classTotal = 0
classCount = 0

for student = 0 to 4 do
    studentTotal = 0
    studentCount = 0

    for assignment = 0 to 2 do
        studentTotal = studentTotal + mark[student][assignment]
        if mark[student][assignment] > 0 then
            studentCount = studentCount + 1
        endif
    endfor

    if studentCount > 0 then
        studentAverage = studentTotal / studentCount
    else
        studentAverage = 0
    endif

    print("Average for Student ", student + 1, ": ", studentAverage)

    classTotal = classTotal + studentTotal
    classCount = classCount + studentCount
endfor

if classCount > 0 then
    classAverage = classTotal / classCount
    print("Class Average: ", classAverage)
else
    print("No valid marks available for class average.")
endif
'''
//PS student_count is incremented, when there is not a "missed" assignment to get the accurate amount of assesments etc etc

//4
//a
//Print the values of the entire grid alond with indices
//b
'''
for row = 0 to 9 do
    for col = 0 to 9 do
        grid[row][col] = 0
    endfor
endfor

randomRow = random(0, 9)  # Random integer between 0 and 9
randomCol = random(0, 9)  # Random integer between 0 and 9

grid[randomRow][randomCol] = 1
'''

  
