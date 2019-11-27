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
            Console.WriteLine("Something that......opens up doors that can't be closed.");
            Thread.Sleep(4000);
            Console.WriteLine("Please enter your journalist's name:");
            string journalistName = Console.ReadLine();
            Console.Clear();

            TheStart(journalistName);

            string enterHospital = Console.ReadLine();
            
            Console.Clear();
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
                Console.Clear();
                

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
                    
                    Console.Clear();
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
                        
                        Console.Clear();
                        int surgeryNum;

                        while (!int.TryParse(surgeryChoice, out surgeryNum))
                        {
                            Console.WriteLine("Please enter a number for a choice:");
                            surgeryChoice = Console.ReadLine();
                        }
                        //release creature or leave it behind......
                        //bad ending
                        if (surgeryNum == 1)
                        {
                            Release(journalistName);
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }
                        //good ending
                        else if (surgeryNum == 2)
                        {
                            LeaveBehind(journalistName);
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);

                        }
                        else
                        {
                            Console.WriteLine("Unfortunately you couldn't make the choice, something grabbed you!");
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);

                        }


                    }
                    else if (securityNum == 2)
                    {
                        BehindDoor(journalistName);
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Console.Clear();
                        Restart(restart);
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately you couldn't make the choice, something grabbed you!");
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Console.Clear();
                        Restart(restart);
                    }

                }
                //doctor offices
                else if (num == 2)
                {
                    DoctorOffice(journalistName);

                    string doctorChoice = Console.ReadLine();
                    
                    Console.Clear();
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
                        Console.Clear();
                        Restart(restart);

                    }
                    else if (doctorNum == 2)
                    {
                        SneakPassed(journalistName);
                        string sneakChoice = Console.ReadLine();
                        
                        Console.Clear();
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
                            Console.Clear();
                            Restart(restart);
                        }
                        //good ending
                        else if (sneakNum == 2)
                        {   
                            InVent(journalistName);
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately you couldn't make the choice, it found you!");
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }

                    }

                    else
                    {
                        Console.WriteLine("Unfortunately you couldn't make the choice, it found you!");
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Console.Clear();
                        Restart(restart);
                    }


                }
                else
                {
                    Console.WriteLine("Unfortunately you couldn't make the choice, something grabbed you from behind!");
                    Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                    string restart = Console.ReadLine();
                    Console.Clear();
                    Restart(restart);

                }
            }

            //This is the start of the second route
            else if (numChoice == 2)
            {
                CellarDoor(journalistName);
                string cellarChoice = Console.ReadLine();
                
                Console.Clear();
                int cellarNum;

                while (!int.TryParse(cellarChoice, out cellarNum))
                {
                    Console.WriteLine("Please enter a number for a choice:");
                    cellarChoice = Console.ReadLine();
                }
                //Morgue or Sterilization route
                if (cellarNum == 1)
                {
                    TheMorgue(journalistName);
                    string morgueChoice = Console.ReadLine();
                    
                    Console.Clear();
                    int morgueNum;

                    while (!int.TryParse(morgueChoice, out morgueNum))
                    {
                        Console.WriteLine("Please enter a number for a choice:");
                        morgueChoice = Console.ReadLine();
                    }

                    if (morgueNum == 1)
                    {
                        UnderSheets(journalistName);
                        string labChoice = Console.ReadLine();
                        
                        Console.Clear();
                        int labNum;

                        while (!int.TryParse(labChoice, out labNum))
                        {
                            Console.WriteLine("Please enter a number for a choice:");
                            labChoice = Console.ReadLine();
                        }
                        //good ending
                        if (labNum == 1)
                        {
                            Cabinets(journalistName);
                            Console.WriteLine("");
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }
                        else if (labNum == 2)
                        {
                            LabDoor(journalistName);
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately you couldn't make the choice, you were grabbed from behind!");
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }
                    }
                    
                    else if (morgueNum == 2)
                    {
                        StorageUnit(journalistName);
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Console.Clear();
                        Restart(restart);
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately you couldn't make the choice, you were grabbed from behind!");
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Console.Clear();
                        Restart(restart);
                    }
                }
                else if (cellarNum == 2)
                {
                    SterilizationRoom(journalistName);
                    string sterilizeChoice = Console.ReadLine();

                    Console.Clear();
                    int sterilizeNum;

                    while (!int.TryParse(sterilizeChoice, out sterilizeNum))
                    {
                        Console.WriteLine("Please enter a number for a choice:");
                        sterilizeChoice = Console.ReadLine();
                    }

                    if (sterilizeNum == 1)
                    {
                        EquipmentCover(journalistName);
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Console.Clear();
                        Restart(restart);
                    }
                    else if (sterilizeNum == 2)
                    {
                        BehindCounter(journalistName);
                        string examChoice = Console.ReadLine();

                        Console.Clear();
                        int examNum;

                        while (!int.TryParse(examChoice, out examNum))
                        {
                            Console.WriteLine("Please enter a number for a choice:");
                            examChoice = Console.ReadLine();
                        }
                        //bad ending
                        if (examNum == 1)
                        {
                            SurgeryHide(journalistName);
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }
                        else if (examNum == 2)
                        {
                            WallLocker(journalistName);
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }
                        else
                        {
                            Console.WriteLine("Unfortunately you couldn't make the choice, you were grabbed from behind!");
                            Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                            string restart = Console.ReadLine();
                            Console.Clear();
                            Restart(restart);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately you couldn't make the choice, you were grabbed from behind!");
                        Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                        string restart = Console.ReadLine();
                        Console.Clear();
                        Restart(restart);
                    }
                }
                else
                {
                    Console.WriteLine("Unfortunately you couldn't make the choice, you were found by the guards!");
                    Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                    string restart = Console.ReadLine();
                    Console.Clear();
                    Restart(restart);
                }
            }
            else
            {
                Console.WriteLine("Unfortunately you couldn't make the choice, you were found by the guards!");
                Console.WriteLine("Would you like to play again? 1: Yes or 2: No?");
                string restart = Console.ReadLine();
                Console.Clear();
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
            Console.WriteLine($"Luckily, being a journalist, {journalistName} always has a flashlight, a camera, and a few other things on hand.");
            Console.WriteLine($"After sneaking past the guards, how should {journalistName} get into the hospital?");
            Console.WriteLine("Seeing how the front door is guarded outside, the only options would be 1: maintenance entrance on the first floor");
            Console.WriteLine("or 2: the cellar entrance.");
            Console.WriteLine($"Which route should {journalistName} take?");
            return journalistName;
        }
        public static string MaintenanceDoor(string journalistName)
        {
            Console.WriteLine($"{journalistName} came out of the woods and crouched up to the maintenance door. ");
            Console.WriteLine($"A common journalist skill that {journalistName} isn't proud of is lockpicking, but it does come in handy. Haha!");
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
        public static string BehindDoor(string journalistName)
        {
            Console.WriteLine($"Still shaken from the blood earlier, {journalistName} panics and runs behind the door.");
            Console.WriteLine($"{journalistName} tries to be quiet as the massive dark figure slowly steps through the doorway.");
            Console.WriteLine($"{journalistName} can hear the figure sniffing loudy, like a wolf searching for it's prey.");
            Console.WriteLine($"Luckily the figure turns away and starts back down the hall..... {journalistName} relaxes too sudden");
            Console.WriteLine($"causes the door to sqeak! {journalistName} looks up where the hinges are and sees two big, yellow eyes");
            Console.WriteLine($"glaring. It's too late....The figure pulls {journalistName} from behind the door.... ");
            Console.WriteLine($"Big yellow eyes are the last thing {journalistName} sees before the end. ");
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
            Console.WriteLine($"Finally making it to the surgery room, {journalistName} starts finding papers on patients that were being experimented on.");
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
            Console.WriteLine($"{journalistName} gathers the rest of the documents and heads back to the maintenance door. ");
            Console.WriteLine($"Sneaking by the guards, {journalistName} makes it back to the car safely.");
            return journalistName;
        }





        public static string DoctorOffice(string journalistName)
        {
            Console.WriteLine($"Going to the second floor is gonna be tricky. {journalistName} is going to have to go to the main reception");
            Console.WriteLine($"area and head up the main flight of stairs without being noticed. {journalistName} sneaks to the main area");
            Console.WriteLine($"with the trail of blood headed the same direction. When {journalistName} arrives at the bottom of the stairs,");
            Console.WriteLine($"the blood is going up the stairs as well. This is very unsettling. {journalistName} turns and looks at the");
            Console.WriteLine($"balcony, catching a glimpse of some massive figure! {journalistName} heart starts pounding! Slowly going up the");
            Console.WriteLine($"stairs, {journalistName} makes sure not to make too much noise. Upon reaching the top, the figure had already ");
            Console.WriteLine($"disappeared. ");
            Console.WriteLine("");
            Console.WriteLine($"{journalistName} makes it to the main doctor's office. While searching the office, {journalistName} ");
            Console.WriteLine($"comes across some papers scattered on the desk. All of them say Classified...Top Secret....Military");
            Console.WriteLine($"Experiments....Genetic Mutation....patients showing signs of accelerated growth rate, aggression, animal features.");
            Console.WriteLine($"{journalistName} takes pictures of the evidence and starts to leave. {journalistName} opens the door and looks");
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
            Console.WriteLine($"The creature howled at {journalistName}! Trying to escape, {journalistName} tried to get around this wolf hybrid only to get");
            Console.WriteLine($"caught in it's claws. ");
            Thread.Sleep(6000);
            Console.WriteLine($"{journalistName} died, screaming for help... ");
            return journalistName;


        }


        public static string SneakPassed(string journalistName)
        {
            Console.WriteLine($"{journalistName} decides to brave the dark hallway where the figure is standing. There was some broken glass on the floor");
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
            Console.WriteLine($"through a vent landing in a hallway on the first floor. {journalistName} gets up and sprints down the hallway");
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
            Console.WriteLine($"{journalistName} decides to go to the Morgue. Trying to be quiet, {journalistName} pushes the door open slowly.");
            Console.WriteLine($"{journalistName} sees bodies covered with sheets on tables and a wall where they store bodies. {journalistName}");
            Console.WriteLine($"decides to lift some of the sheets to look at the bodies only to realize that not all of them are human...");
            Console.WriteLine($"Some of them are animals. Why would there be animals at a mental hospital? The last sheet {journalistName} lifts");
            Console.WriteLine($"the human body shows animal features! Could there have been human experiments? While {journalistName} is looking around,");
            Console.WriteLine($"something starts trying to open the door! {journalistName} starts panicing! Where to hide?!?! {journalistName} can 1: hide");
            Console.WriteLine($"under one of the sheets with one of the bodies or 2: get in one of the storage units on the wall?");

            return journalistName;
        }

        public static string UnderSheets(string journalistName)
        {
            Console.WriteLine($"{journalistName} doesn't have much time to choose where to hide! Panicing, {journalistName} gets under one of the sheets");
            Console.WriteLine($"on one of the tables! The bad part of it is {journalistName} is covered up with one of the dead bodies.... ");
            Console.WriteLine($"The door finally opens up! {journalistName} tries to not cough due to the smell of the body....");
            Thread.Sleep(15000);
            Console.WriteLine("");
            Console.WriteLine($"{journalistName} can see the dark figure walking closer to the table! The figure starts to run its hands down") ;
            Console.WriteLine($"the sheet! The hand gets right in front of {journalistName}'s face! {journalistName} is drenched with sweat!");
            Console.WriteLine($"The figure starts to grab the sheet and lift it up.....!");
            Thread.Sleep(15000);
            Console.WriteLine("");
            Console.WriteLine($"Suddenly the figure stops and walks away torwards the storage units... The figure opens up one of the units and");
            Console.WriteLine($"roars like a bear! Then it sounds like it is starting eating something. {journalistName} passes out from the ");
            Console.WriteLine($"body and wakes up later to find that the creature has left.... Getting up from the table, {journalistName}");
            Console.WriteLine($"continues through the next door into a hallway. {journalistName} sees a light coming from a room farther down.");
            Console.WriteLine($"{journalistName} sneaks up to the door and slowly opens it up. Luckily no one is inide, but {journalistName}");
            Console.WriteLine($"does find a research lab. {journalistName} starts looking on the computers and finds notes on experiments.");
            Console.WriteLine($"Apparently the military was doing experiments on patients at the hospital. They were trying something called");
            Console.WriteLine($"gene mutation. They were trying to make Super Soldiers! {journalistName} gets all the info needed to write");
            Console.WriteLine($"the article. {journalistName} hears something coming down the hallway! {journalistName} tries to figure out ");
            Console.WriteLine($"where to hide! The only options are 1: get in one of the cabinets or 2: behind the door?");
            return journalistName;
        }

        public static string Cabinets(string journalistName)
        {
            Console.WriteLine($"Rushing to hide, {journalistName} opens up a cabinet and removes everything in it! {journalistName} gets");
            Console.WriteLine($"inside the cabinet before the creature walks in! {journalistName} takes a slow deep breath to calm down");
            Console.WriteLine($"so the creature doesn't hear...");
            Thread.Sleep(10000);
            Console.WriteLine("");
            Console.WriteLine($"It's dead silent... You could hear a pen drop.");
            Thread.Sleep(10000);
            Console.WriteLine("");
            Console.WriteLine($"Then {journalistName} hears a can get kicked next to the cabinet! {journalistName} starts to get a cold");
            Console.WriteLine($"sweat... The cabinet door starts to open! {journalistName} can see some sort of bear like monster!");
            Console.WriteLine("");
            Thread.Sleep(10000);
            Console.WriteLine($"It's trying to open the cabinet!!! {journalistName} is about to scream!");
            Console.WriteLine("");
            Thread.Sleep(6000);
            Console.WriteLine($"The creature stops, there is a loud crash down the hall. The creature runs down the hall");
            Console.WriteLine($"torwards the sound of the crash...SAFE!!! {journalistName} is relieved, starting to tear up.");
            Console.WriteLine($"{journalistName} takes the opportunity to escape back torwards the cellar. {journalistName} manages");
            Console.WriteLine($"to emerge from the cellar shaken but unharmed. {journalistName} goes back through the woods and ");
            Console.WriteLine($"makes it back to the car. Sitting in the car, {journalistName} wonders what would be in store if");
            Console.WriteLine($"the article ever gets posted....");
            return journalistName;
        }

        public static string LabDoor(string journalistName)
        {
            Console.WriteLine($"Still shaken from the blood earlier, {journalistName} panics and runs behind the door.");
            Console.WriteLine($"{journalistName} tries to be quiet as the massive dark figure slowly steps through the doorway.");
            Console.WriteLine($"{journalistName} can hear the figure make noises like a bear intimidating another predator.");
            Console.WriteLine($"Luckily the figure turns away and starts back down the hall..... {journalistName} relaxes too sudden");
            Console.WriteLine($"causes the door to sqeak! The figure smashes through the door!");
            Console.WriteLine($"It's too late....The figure pulls {journalistName} from behind the door....");
            Console.WriteLine($"{journalistName} gets eaten alive!");           
            return journalistName;
        }

        public static string StorageUnit(string journalistName)
        {
            Console.WriteLine($"{journalistName} runs to one of the body storage units! Luckily there was one that was empty!");
            Console.WriteLine($"{journalistName} climbs in and keeps the drawer cracked so it doesn't lock. {journalistName}");
            Console.WriteLine($"can hear something getting closer....");
            Console.WriteLine("");
            Thread.Sleep(10000);
            Console.WriteLine($"The drawer slides open with so much force that {journalistName}'s sight goes blurry. A massive");
            Console.WriteLine($"figure is standing over {journalistName}.... It's too late.... the creature slashes open");
            Console.WriteLine($"{journalistName}'s chest! {journalistName} passes out and dies.");
            return journalistName;
        }


        public static string SterilizationRoom(string journalistName)
        {
            Console.WriteLine($"{journalistName} goes down the dark hallway and comes across double doors. {journalistName}");
            Console.WriteLine($"realizes that it's a sterilization room for surgery equipment. While searching the room,");
            Console.WriteLine($"{journalistName} notices that there is equipment for humans and animals by the descriptions");
            Console.WriteLine($"on the machines. Which seems odd being a human hospital. There were also dirty utensils");
            Console.WriteLine($"with animal hairs. Something isn't adding up. ");
            Console.WriteLine("");
            Thread.Sleep(15000);
            Console.WriteLine($"All of a sudden the doors swing open! A furry Massive figure walks through!");
            Console.WriteLine($"{journalistName} only has two choices, either 1: hide under some equipment covers or ");
            Console.WriteLine($"2: get down behind a counter?");
            return journalistName;
        }

        public static string EquipmentCover(string journalistName)
        {
            Console.WriteLine($"{journalistName} quickly gets under some equipment covers! There is a pool of blood");
            Console.WriteLine($" below {journalistName}! {journalistName} slips and falls, ripping the");
            Console.WriteLine($"covers off! The horror standing in front of {journalistName} is a hybrid creature with");
            Console.WriteLine($"human and bear traits...{journalistName} is quickly dismembered from the massive claws");
            Console.WriteLine($"of the creature!");
            return journalistName;
        }

        public static string BehindCounter(string journalistName)
        {
            Console.WriteLine($"{journalistName} doesn't have time to hide anywhere except getting behind the counter");
            Console.WriteLine($"near by! The massive creature starts to move around the counter. {journalistName} moves");
            Console.WriteLine($"the opposite way as quietly as possible. {journalistName} doesn't see the tray of needles");
            Console.WriteLine($"sitting at the edge of the counter. {journalistName}'s head bumps into the tray causing");
            Console.WriteLine($"the needles to fall! One ends up sticking {journalistName} in the leg! The creature turns");
            Console.WriteLine($"around and roars! {journalistName} takes off running the wrong direction! {journalistName}");
            Console.WriteLine($"is headed further into the hospital! With the creature close behind, {journalistName} sees");
            Console.WriteLine($"a staircase leading up to the surgery floor! {journalistName} makes it to the top and slams");
            Console.WriteLine($"the door behind! The creature starts beating on the door! {journalistName} has to hide ");
            Console.WriteLine($"before the door breaks! 1: In the surgery room with the lights off or 2: in a wall locker?!");
            return journalistName;
        }

        public static string SurgeryHide(string journalistName)
        {
            Console.WriteLine($"{journalistName} runs into the surgery room, turning the lights completely off!");
            Console.WriteLine($"{journalistName} can see the Beast through the window destroying the other room trying");
            Console.WriteLine($"to find it's pray! {journalistName} stays quiet but starts to feel weird. The room is ");
            Console.WriteLine($"starting to spin and {journalistName} is getting dizzy!");
            Console.WriteLine("");
            Thread.Sleep(12000);
            Console.WriteLine($"OH NO, THE NEEDLE! Something must have been in the needle still! {journalistName} passes out!");
            Thread.Sleep(9000);
            Console.WriteLine("");
            Console.WriteLine($"{journalistName} wakes up looking at the ceiling with bright lights. {journalistName} can't");
            Console.WriteLine($"move! {journalistName} is strapped to a surgery table! there are doctors standing around the");
            Console.WriteLine($"table! {journalistName} can overhear them saying that this will be human trials #4!");
            Console.WriteLine($"{journalistName} passes out again!");
            Thread.Sleep(12000);
            Console.WriteLine("");
            Console.WriteLine($"{journalistName} finally wakes up again in the hospital laying against a wall. Getting up, ");
            Console.WriteLine($"{journalistName} feels different.....Taller.....");
            Thread.Sleep(8000);
            Console.WriteLine("");
            Console.WriteLine($"Angry....");
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("Outrageously Hungry....");
            Console.WriteLine($"Something isn't right! {journalistName} finds a mirror... {journalistName} yells with a big");
            Console.WriteLine($"roar! As light fades into darkness, {journalistName} joins the beasts");
            Console.WriteLine($"roaming the hospital....");
            return journalistName;
        }

        public static string WallLocker(string journalistName)
        {
            Console.WriteLine($"{journalistName} runs to a wall locker near the surgery room! {journalistName} hears");
            Console.WriteLine($"the door break down! The beast franticly searches the room! The beast flips desks and");
            Console.WriteLine($"throws chairs trying to find {journalistName}! Then silence......");
            Thread.Sleep(6000);
            Console.WriteLine("......");
            Thread.Sleep(6000);
            Console.WriteLine($"The Beast rips the wall locker open! {journalistName} screams for help to no avail!");
            Console.WriteLine($"The Beast strangles {journalistName} to death!");
            return journalistName;
        }


    }
}
