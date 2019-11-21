using System;
using System.Threading;

namespace MentalHospitalTextAd
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Journalism was created to uncover the truth about mysteries.");
            Thread.Sleep(4000);
            Console.WriteLine("Mysteries that are meant to be solved and shown to the world.");
            Thread.Sleep(4000);
            Console.WriteLine("Sometimes a journalist can go too far and get involved in something they only thought they understood.");
            Thread.Sleep(4000);
            Console.WriteLine("Something that......opens up doors that can't be shut.");
            Thread.Sleep(4000);
            Console.WriteLine("Please enter your journalist's name:");
            string journalistName = Console.ReadLine();

            TheStart(journalistName);

            string enterHospital = Console.ReadLine();
            Console.WriteLine("");
            int numChoice;
            while (!int.TryParse(enterHospital, out numChoice))
            {
                Console.WriteLine("Please enter a number for a choice:");
                enterHospital = Console.ReadLine();
            }
            //This is the start of the first route
            if (numChoice == 1)
            {
                MaintenanceDoor(journalistName);

                string mainHospital = Console.ReadLine();

                Console.WriteLine("");

                int num;
                while (!int.TryParse(mainHospital, out num))
                {
                    Console.WriteLine("Please enter a number for a choice:");
                    mainHospital = Console.ReadLine();
                }

                //Security office or doctor office
                if (num == 1)
                {
                    SecurityOffice(journalistName);

                    string securityChoice = Console.ReadLine();
                    Console.WriteLine("");

                    int securityNum;

                    while (!int.TryParse(securityChoice, out securityNum))
                    {
                        Console.WriteLine("Please enter a number for a choice:");
                        securityChoice = Console.ReadLine();
                    }

                    //under desk or behind door
                    if (securityNum == 1)
                    {
                        UnderDesk(journalistName);
                        SurgeryRoom(journalistName);
                        string surgeryChoice = Console.ReadLine();
                        Console.WriteLine("");

                        int surgeryNum;

                        while (!int.TryParse(surgeryChoice, out surgeryNum))
                        {
                            Console.WriteLine("Please enter a number for a choice:");
                            surgeryChoice = Console.ReadLine();
                        }

                        if (surgeryNum == 1)
                        {
                            Release(journalistName);
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Restart(restart);
                        }
                        else if (surgeryNum == 2)
                        {
                            LeaveBehind(journalistName);
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately you couldn't make the choice, something grabbed you!");
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Restart(restart);

                        }


                    }
                    else if (securityNum == 2)
                    {
                        BehindDoor(journalistName);
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Restart(restart);
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately you couldn't make the choice, something grabbed you!");
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Restart(restart);
                    }

                }
                //doctor offices
                else if (num == 2)
                {
                    DoctorOffice(journalistName);

                    string doctorChoice = Console.ReadLine();
                    Console.WriteLine("");

                    int doctorNum;

                    while (!int.TryParse(doctorChoice, out doctorNum))
                    {
                        Console.WriteLine("Please enter a number for a choice:");
                        doctorChoice = Console.ReadLine();
                    }
                    //stay in room or sneak to stairs
                    if (doctorNum == 1)
                    {
                        StayInOffice(journalistName);
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Restart(restart);

                    }
                    else if (doctorNum == 2)
                    {
                        SneakPassed(journalistName);
                        string sneakChoice = Console.ReadLine();
                        Console.WriteLine("");

                        int sneakNum;

                        while (!int.TryParse(sneakChoice, out sneakNum))
                        {
                            Console.WriteLine("Please enter a number for a choice:");
                            sneakChoice = Console.ReadLine();
                        }

                        if (sneakNum == 1)
                        {
                            UnderBed(journalistName);

                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Restart(restart);
                        }
                        else if (sneakNum == 2)
                        {
                            InVent(journalistName);
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Restart(restart);
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately you couldn't make the choice, it found you!");
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Restart(restart);
                        }

                    }

                    else
                    {
                        Console.WriteLine("Unfortunately you couldn't make the choice, it found you!");
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Restart(restart);
                    }


                }
                else
                {
                    Console.WriteLine("Unfortunately you couldn't make the choice, something grabbed you from behind!");
                    Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                    string restart = Console.ReadLine();
                    Restart(restart);

                }
            }

            //This is the start of the second route
            else if (numChoice == 2)
            {
                CellarDoor(journalistName);
                string cellarChoice = Console.ReadLine();
                Console.WriteLine("");

                int cellarNum;

                while (!int.TryParse(cellarChoice, out cellarNum))
                {
                    Console.WriteLine("Please enter a number for a choice:");
                    cellarChoice = Console.ReadLine();
                }

                if (cellarNum == 1)
                {
                    TheMorgue(journalistName);
                }
                else if (cellarNum == 2)
                {
                    SterilizationRoom(journalistName);
                }
                else
                {
                    Console.WriteLine("Unfortunately you couldn't make the choice, you were found by the guards!");
                    Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                    string restart = Console.ReadLine();
                    Restart(restart);
                }
            }
            else
            {
                Console.WriteLine("Unfortunately you couldn't make the choice, you were found by the guards!");
                Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                string restart = Console.ReadLine();
                Restart(restart);


            }





        }


        public static void Restart(string restart)
        {

            int restartNum;
            while (!int.TryParse(restart, out restartNum))
            {
                Console.WriteLine("Please enter a 1 or 2:");
                restart = Console.ReadLine();
            }
            if (restartNum == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");


                Main(null);
            }
            else
            {
                Environment.Exit(0);
            }
            return;

        }


        public static string TheStart(string journalistName)
        {
            Console.WriteLine("");
            Console.WriteLine($"The story begins with a journalist's named {journalistName}.");
            Thread.Sleep(2000);
            Console.WriteLine("Well known for uncovering some of the biggest mysteries throughout the U.S.,");
            Console.WriteLine($"{journalistName} came across a piece of information about an abandoned mental hospital.");
            Console.WriteLine("It was a well known hospital. The problem is that no one could explain why it was abandoned.");
            Console.WriteLine("One minute it was open, the next, not a soul in sight.");
            Console.WriteLine("Another weird thing about the place is that no one could go in, it was off limits.....");
            Console.WriteLine("QUARANTINED: MILITARY ONLY!!!");
            Console.WriteLine("");
            Console.WriteLine($"So {journalistName} decides to sneak in the hospital and uncover the truth.");
            Console.WriteLine("The main entrance was guarded by military so the only way is through the woods.");
            Console.WriteLine($"Luckily, being a journalist, {journalistName} always has a flashlight, a camera and a few other things on hand.");
            Console.WriteLine($"After sneaking past the guards, how should {journalistName} get into the hospital?");
            Console.WriteLine("Seeing how the front door is guarded outside, the only options would be 1: maintenance entrance on the first floor");
            Console.WriteLine("or 2: the cellar entrance.");
            Console.WriteLine($"Which route should {journalistName} take?");
            return journalistName;
        }
        public static string MaintenanceDoor(string journalistName)
        {
            Console.WriteLine($"{journalistName} came out of the woods and crouched up to the maintenance door. ");
            Console.WriteLine("A common journalist skill that they aren't proud of is lockpicking, but it does come in handy. Haha!");
            Console.WriteLine($"Opening the door, {journalistName} slips in unnoticed, only to realize the trail of blood leading from the door to the");
            Console.WriteLine($"main part of the hospital. Chills start running down {journalistName}'s spine, thinking about what could");
            Console.WriteLine("have caused the blood. It looks like someone was being pulled on the ground.");
            Console.WriteLine($"{journalistName} continued on after recovering from the shock of the scene.");

            Console.WriteLine("The maintenance area led to one of the main hallways in the hospital. Which way now?");
            Console.WriteLine($"Does {journalistName} go check the security guard office for clues or ");
            Console.WriteLine("go look in the doctor's office on the second floor?");
            Console.WriteLine("1: security office or 2: doctor's office?");
            return journalistName;

        }

        public static string SecurityOffice(string journalistName)
        {

            Console.WriteLine($"while going torwards the security office, {journalistName} noticed most of the lights were off ");
            Console.WriteLine($"thoughout the hospital. Which seems odd if the military is supposedly using it. Another thing {journalistName} ");
            Console.WriteLine($"noticed was no one was inside, not a soul. {journalistName} feels uneasy after seeing claw");
            Console.WriteLine($"marks on the walls.... {journalistName} takes a deep breath and kept moving to the security office.");
            Console.WriteLine($"Having made it to the security office, {journalistName} started looking around for clues.");
            Console.WriteLine("The security cameras were still on, luckily. Nothing was showing at the moment.");
            Console.WriteLine($"{journalistName} starts looking through paperwork to see if anything sticks out.");
            Console.WriteLine($"While doing that, something moved across the screen of one of the cameras. {journalistName} didn't see it.");
            Console.WriteLine($"However, {journalistName} did start to hear something coming down the hall torwards the security office. Then the sound of");
            Console.WriteLine($"what reminds you of sharp nails on a chalk board. The sound was getting closer!");
            Thread.Sleep(15000);
            Console.WriteLine($"{journalistName} has to hide, but where?!?! The only places are 1: under the desk or 2: behind the door?");
            return journalistName;

        }

        public static string UnderDesk(string journalistName)
        {

            Console.WriteLine($"{journalistName} tries to remain calm and gets under the desk in the room. A massive dark figure walks through");
            Console.WriteLine($"the doorway. The figure starts sniffing loudy like a wolf searching for it's prey. the figure walks up to the desk ");
            Console.WriteLine($"and runs it's claws across it as it searches the room. Sweat is running down {journalistName}'s face hoping not to be found.");
            Console.WriteLine($"Luckily, the figure gives up and heads back into the hallway. After a little while {journalistName} moves from the desk");
            Console.WriteLine($"and rewinds the tapes on the cameras. {journalistName} still can't see the figure really well except that it has fur ");
            Console.WriteLine($"and what looks like an animal head.... {journalistName} is confused and nervous at the same time because the creature");
            Console.WriteLine($"will eventually return. {journalistName} may not be lucky next time.");
            Console.WriteLine($"{journalistName} doesn't find anything helpful in the security office other than coming too close to an unfrieldly creature.");
            Console.WriteLine($"{journalistName} decides to continue on. Maybe there will be clues in the surgery area. ");
            Console.WriteLine("");
            return journalistName;

        }


        public static string SurgeryRoom(string journalistName)
        {
            Thread.Sleep(20000);
            Console.WriteLine($"While on the way to the surgery area, {journalistName} starts seeing blood everywhere in the hallway.....Then......");
            Thread.Sleep(6000);
            Console.WriteLine("");
            Console.WriteLine("BODIES.....EVERYWHERE..... like a war had broken out inside the hospital.");
            Console.WriteLine("");
            Console.WriteLine($"{journalistName} was getting nauseous from the scene. Bodies ripped apart. Blood all over the walls.");
            Console.WriteLine($"Finally making it to the surgery room, {journalistName} starts finding papers on what seems like experiments on patients.");
            Console.WriteLine($"Some of the papers stating genetic mutation and gene splicing. Apparently the military is working on super soldiers.");
            Console.WriteLine($"{journalistName} found the clues about what happened here, but noises were coming from the surgery room.....");
            Thread.Sleep(12000);
            Console.WriteLine($"H...E...L...P...");
            Thread.Sleep(6000);
            Console.WriteLine($"So {journalistName} investigates and finds a reptile creature strapped to a surgery table! It's asking for help! ");
            Console.WriteLine($"{journalistName} only has to push a button to release the creature. {journalistName} is on the other side of the glass");
            Console.WriteLine($"where it is safe. Should {journalistName} 1: Release the creature or 2: leave it behind? ");
            return journalistName;

        }

        public static string Release(string journalistName)
        {
            Console.WriteLine($"Having released the creature and having peace of mind, {journalistName} found the rest of the documents needed to finish ");
            Console.WriteLine($"the article. {journalistName} reuturns to the maintenance door only to find that the door was wide open....");
            Console.WriteLine($"{journalistName} hurried back down through the woods with the documents! With every step, {journalistName} became more");
            Console.WriteLine($"uneasy. Finally making it to the car, {journalistName} jumped in and locked the door.");
            Thread.Sleep(10000);
            Console.WriteLine($"SAFE!");
            Thread.Sleep(10000);
            Console.WriteLine($"Until the creature {journalistName} had saved was in the backseat of the car......");
            Console.WriteLine($"All you can see is the car shaking and {journalistName}'s screams.....");
            return journalistName;
        }



        public static string LeaveBehind(string journalistName)
        {
            Console.WriteLine($"Not trusting the creature, {journalistName} can't make the choice.....");
            Console.WriteLine($"{journalistName} gathers the rest of the documents and heads back to the maintenance door. Sneaking by the guards,");
            Console.WriteLine($"{journalistName} makes it back to the car safely.");
            return journalistName;
        }




        public static string BehindDoor(string journalistName)
        {
            Console.WriteLine($"Still shaken from the blood earlier, {journalistName} panics and runs behind the door.");
            Console.WriteLine($"{journalistName} tries to be quiet as the massive dark figure slowly steps through the doorway.");
            Console.WriteLine($"{journalistName} can hear the figure sniffing loudy, like a walf searching for it's prey.");
            Console.WriteLine($"Luckily the figure turns away and starts back down the hall..... {journalistName} relaxes too sudden");
            Console.WriteLine($"causes the door to sqeak! {journalistName} looks up where the hinges are and sees two big, yellow eyes");
            Console.WriteLine($"glaring. It's too late....The figure pulls {journalistName} from behind the door.... Screams and two yellow");
            Console.WriteLine($"eyes are the last thing {journalistName} hears and sees before the end. ");
            return journalistName;


        }

        public static string DoctorOffice(string journalistName)
        {
            Console.WriteLine($"Going to the second floor is gonna be tricky. {journalistName} is going to have to go to the main reception");
            Console.WriteLine($"area and head up the main flight of stairs without being noticed. {journalistName} sneaks to the main area");
            Console.WriteLine($"with the trail of blood headed the same direction. When {journalistName} arrives at the bottom of the stairs,");
            Console.WriteLine($"the blood trail going up the stairs as well. This is very unsettling. {journalistName} turns and looks at the");
            Console.WriteLine($"balcony, catching a glimpse of some massive figure! {journalistName} heart starts pounding! Slowly going up the");
            Console.WriteLine($"stairs, {journalistName} makes sure not to make too much noise. Upon reaching the top, the figure had already ");
            Console.WriteLine($"disappeared. ");
            Console.WriteLine("");
            Console.WriteLine($"{journalistName} makes it to the main doctor's office. While searching office, {journalistName} ");
            Console.WriteLine($"comes across some papers scattered on the desk. All of them say Classified...Top Secret....Military");
            Console.WriteLine($"Experiments....Genetic Mutation....patients showing signs of accelerated growth rate, aggression, animal features.");
            Console.WriteLine($"{journalistName} takes pictures of the evidence and starts to leave. When {journalistName} opens the door and looks");
            Console.WriteLine($"left. Something is at the end of the hallway and it's not moving. What should {journalistName} do? 1: wait to see if it passes");
            Console.WriteLine($"or 2: try to sneak to the stairs?");
            return journalistName;
        }

        public static string StayInOffice(string journalistName)
        {
            Console.WriteLine($"{journalistName} decides to wait it out to see if the massive figure will pass. While waiting, {journalistName} looks");
            Console.WriteLine($"over the files some more and starts to wondering if something went wrong with the experiments and they somehow escaped.");
            Thread.Sleep(6000);
            Console.WriteLine($"Reading the files more and more, {journalistName} wonders if that figure is one of the escaped patients. So caught up in");
            Console.WriteLine($"the files, {journalistName} didn't realize the door had opened up! The figure was staring right at {journalistName}! ");
            Thread.Sleep(6000);
            Console.WriteLine($"The creature howled at {journalistName}! Trying to escape, {journalistName} tried to get around this wolf hybrid only to");
            Console.WriteLine($"caught in it's claws. ");
            Thread.Sleep(6000);
            Console.WriteLine($"{journalistName} died, screaming for help... ");
            return journalistName;


        }


        public static string SneakPassed(string journalistName)
        {
            Console.WriteLine($"{journalistName} decides to brave the dark hallway where the figure was standing. There was some broken glass on the floor");
            Console.WriteLine($"{journalistName} didn't see when coming from the stairs earlier. {journalistName} steps on the broken glass!");
            Console.WriteLine("");
            Thread.Sleep(6000);
            Console.WriteLine("CRACK!!!!");
            Thread.Sleep(6000);
            Console.WriteLine("");
            Console.WriteLine($"{journalistName} freezes! Turns and looks at the figure at the end of the hallway. The figure is staring at {journalistName}.");
            Console.WriteLine($"The figure howls at {journalistName}! {journalistName} takes off sprinting down the hallway with the creature chasing ");
            Console.WriteLine($"behind! While running,{journalistName} keeps checking doors but they are locked! Finally, as the creature gets closer, {journalistName}");
            Console.WriteLine($"finds a door unlocked! {journalistName} hurrys inside and tries to find a hiding space! It's a patient's room with a bed");
            Console.WriteLine($"and an open air vent big enough to fit in. Should {journalistName} 1: get under the bed or 2: get in the vent?");

            return journalistName;
        }

        public static string UnderBed(string journalistName)
        {
            Console.WriteLine($"{journalistName} runs and gets under the bed right before the creature comes in! The creature comes in and closes the door.");
            Console.WriteLine($"The room goes quiet....{journalistName} takes out his video camera and turns on his night vision. {journalistName} starts");
            Console.WriteLine($"scanning the room from under the bed. As {journalistName} is panning the room, a head comes into view! It's a wolf head!");
            Thread.Sleep(6000);
            Console.WriteLine($"It's too late!!! The creature grabs {journalistName}! {journalistName} screams in total darkness as the creature feeds....");
            return journalistName;
        }

        public static string InVent(string journalistName)
        {
            Console.WriteLine($"{journalistName} runs into the room and sees an air vent big enough to squeeze in! While holding the cover of the");
            Console.WriteLine($"vent with just hands, {journalistName} tries to stay quiet... All of a sudden the lights flip on and the creature");
            Console.WriteLine($"lunges at the vent! {journalistName} gets pushed back and falls down the ventilation shaft! {journalistName} slams");
            Console.WriteLine($"slams through a vent landing in a hallway on the first floor. {journalistName} gets up and sprints down the hallway");
            Console.WriteLine($"back torwards the maintenance door! Hearing the Howl of the Beast as it gets closer, {journalistName} feels like ");
            Console.WriteLine($"passing out! Making it the maintenance door, {journalistName} forgets to lock it back! Running back to the car,");
            Console.WriteLine($"{journalistName} can hear the screams of the guards and a howl in the woods!!! {journalistName} barely makes it out");
            Console.WriteLine($"alive..... wondering if the article show even be posted.....");
            return journalistName;
        }



        public static string CellarDoor(string journalistName)
        {
            Console.WriteLine($"{journalistName} sneaks up to the cellar door only to find out that it has been");
            Console.WriteLine($"locked from the inside. {journalistName} sees a crowbar laying in the grass next to the building.");
            Console.WriteLine($"{journalistName} takes the crowbar and pries the door open, which makes a loud sound causing the guards");
            Console.WriteLine($"to come running! While panicing, {journalistName} manages to slip inside right before the");
            Console.WriteLine("guards show up!");
            Console.WriteLine("");
            Console.WriteLine($"Turning on the flashlight, {journalistName} is startled by a dark shadow on the wall!");
            Console.WriteLine($"{journalistName} realizes it's just a manikin....After calming down, {journalistName} continues down the hallway ");
            Console.WriteLine($"leading into the hospital. There are only two doors to choose from in the hallway. 1: The Morgue or ");
            Console.WriteLine($"2: Sterilization Room. Which path should {journalistName} take?");
            return journalistName;


        }

        public static string TheMorgue(string journalistName)
        {
            Console.WriteLine("dead");

            return journalistName;
        }


        public static string SterilizationRoom(string journalistName)
        {

            return journalistName;
        }



    }
}
