using Lesson_9_Alarm;

ClockImitation Alarm1 = new ClockImitation(3, "I'm first user. And I start first Alarm. ");
Observer FirstObserver = new Observer();
FirstObserver.AddObsreverNotification(Alarm1);

Alarm1.Alarm();
