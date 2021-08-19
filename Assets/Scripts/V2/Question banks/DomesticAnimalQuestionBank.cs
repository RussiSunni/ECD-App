using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using V2;

public class DomesticAnimalQuestionBank : Question
{
    public static List<Question> domesticAnimalNameQuestions = new List<Question>();
    public static Question domesticAnimalName001 = new Question();
    public static Question domesticAnimalName002 = new Question();
    public static Question domesticAnimalName003 = new Question();
    public static Question domesticAnimalName004 = new Question();
    public static Question domesticAnimalName005 = new Question();
    public static Question domesticAnimalName006 = new Question();
    public static Question domesticAnimalName007 = new Question();
    public static Question domesticAnimalName008 = new Question();
    public static Question domesticAnimalName009 = new Question();
    public static Question domesticAnimalName010 = new Question();
    public static Question domesticAnimalName011 = new Question();

    void Start()
    {

        domesticAnimalName001 = new Question()
        {
            number = 1,
            questionName = "cat",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Cat"),
            answerBlocks = new List<char>()
        {
            'C',
            'A',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Cat"
        };

        domesticAnimalName002 = new Question()
        {
            number = 2,
            questionName = "dog",
            sprite = Resources.Load<Sprite>("V2/VocabImages/DOG"),
            answerBlocks = new List<char>()
        {
            'D',
            'O',
            'G'
                    },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Dog"
        };

        domesticAnimalName003 = new Question()
        {
            number = 3,
            questionName = "horse",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Horse"),
            answerBlocks = new List<char>()
        {
            'H',
            'O',
            'R',
            'S',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Horse"
        };

        domesticAnimalName004 = new Question()
        {
            number = 13,
            questionName = "cow",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Cow"),
            answerBlocks = new List<char>()
        {
            'C',
            'O',
            'W'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Cow"
        };

        domesticAnimalName005 = new Question()
        {
            number = 14,
            questionName = "duck",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Duck"),
            answerBlocks = new List<char>()
        {
            'D',
            'U',
            'C',
            'K'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Duck"
        };

        domesticAnimalName006 = new Question()
        {
            number = 15,
            questionName = "pig",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Pig"),
            answerBlocks = new List<char>()
        {
            'P',
            'I',
            'G'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Pig"
        };

        domesticAnimalName007 = new Question()
        {
            number = 16,
            questionName = "donkey",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Donkey"),
            answerBlocks = new List<char>()
        {
            'D',
            'O',
            'N',
            'K',
            'E',
            'Y'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Donkey"
        };

        domesticAnimalName008 = new Question()
        {
            number = 20,
            questionName = "goat",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Goat"),
            answerBlocks = new List<char>()
        {
            'G',
            'O',
            'A',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Goat"
        };

        domesticAnimalName009 = new Question()
        {
            number = 21,
            questionName = "chicken",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Chicken"),
            answerBlocks = new List<char>()
        {
            'C',
            'H',
            'I',
            'C',
            'C',
            'K',
            'E',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Chicken"
        };

        domesticAnimalName010 = new Question()
        {
            number = 29,
            questionName = "sheep",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Sheep"),
            answerBlocks = new List<char>()
        {
            'S',
            'H',
            'E',
            'E',
            'P'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Sheep"
        };

        domesticAnimalName011 = new Question()
        {
            number = 35,
            questionName = "mouse",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Mouse"),
            answerBlocks = new List<char>()
        {
            'M',
            'O',
            'U',
            'S',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Mouse"
        };
    }

    public static void LoadQuestionList()
    {
        // if (GameControl.animalName001known == false)
        domesticAnimalNameQuestions.Add(domesticAnimalName001);

        // if (!GameControl.animalName002known)
        domesticAnimalNameQuestions.Add(domesticAnimalName002);

        // if (!GameControl.animalName003known)
        domesticAnimalNameQuestions.Add(domesticAnimalName003);

        // if (!GameControl.animalName013known)
        domesticAnimalNameQuestions.Add(domesticAnimalName004);

        // if (!GameControl.animalName014known)
        domesticAnimalNameQuestions.Add(domesticAnimalName005);

        // if (!GameControl.animalName015known)
        domesticAnimalNameQuestions.Add(domesticAnimalName006);

        // if (!GameControl.animalName016known)
        domesticAnimalNameQuestions.Add(domesticAnimalName007);

        // if (!GameControl.animalName020known)
        domesticAnimalNameQuestions.Add(domesticAnimalName008);

        // if (!GameControl.animalName021known)
        domesticAnimalNameQuestions.Add(domesticAnimalName009);

        // if (!GameControl.animalName029known)
        domesticAnimalNameQuestions.Add(domesticAnimalName010);

        // if (!GameControl.animalName035known)
        domesticAnimalNameQuestions.Add(domesticAnimalName011);

        //questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();
    }
}
