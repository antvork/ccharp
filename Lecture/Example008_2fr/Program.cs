int count=0, distance = 1000000, first_friend_speed = 1, second_friend_speed = 2, dog_speed = 5, friend = 2, time = 0;
while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
    }
    else
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
    }

    distance = distance - (first_friend_speed + second_friend_speed) * time;
    count++;
}
Console.WriteLine(count);