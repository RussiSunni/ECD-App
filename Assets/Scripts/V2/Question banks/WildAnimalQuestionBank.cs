using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using V2;
public class WildAnimalQuestionBank : Question
{
    public static List<Question> questions = new List<Question>();
    public static Question animalName004 = new Question();
    public static Question animalName005 = new Question();
    public static Question animalName006 = new Question();
    public static Question animalName007 = new Question();
    public static Question animalName008 = new Question();
    public static Question animalName009 = new Question();
    public static Question animalName010 = new Question();
    public static Question animalName011 = new Question();
    public static Question animalName012 = new Question();
    public static Question animalName017 = new Question();
    public static Question animalName018 = new Question();
    public static Question animalName019 = new Question();
    public static Question animalName022 = new Question();
    public static Question animalName023 = new Question();
    public static Question animalName024 = new Question();
    public static Question animalName025 = new Question();
    public static Question animalName026 = new Question();
    public static Question animalName027 = new Question();
    public static Question animalName028 = new Question();
    public static Question animalName030 = new Question();
    public static Question animalName031 = new Question();
    public static Question animalName032 = new Question();
    public static Question animalName033 = new Question();
    public static Question animalName034 = new Question();

    void Start()
    {
        animalName004 = new Question()
        {
            number = 4,
            questionName = "bear",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Bear"),
            answerBlocks = new List<char>()
        {
            'B',
            'E',
            'A',
            'R'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bear"
        };

        animalName005 = new Question()
        {
            number = 5,
            questionName = "wolf",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Wolf"),
            answerBlocks = new List<char>()
        {
            'W',
            'O',
            'L',
            'F'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Wolf"
        };

        animalName006 = new Question()
        {
            number = 6,
            questionName = "zebra",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Zebra"),
            answerBlocks = new List<char>()
        {
            'Z',
            'E',
            'B',
            'R',
            'A'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Zebra"
        };

        animalName007 = new Question()
        {
            number = 7,
            questionName = "owl",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Owl"),
            answerBlocks = new List<char>()
        {
            'O',
            'W',
            'L'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Owl"
        };

        animalName008 = new Question()
        {
            number = 8,
            questionName = "monkey",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Monkey"),
            answerBlocks = new List<char>()
        {
            'M',
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
            answerSound = "Monkey"
        };

        animalName009 = new Question()
        {
            number = 9,
            questionName = "parrot",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Parrot"),
            answerBlocks = new List<char>()
        {
            'P',
            'A',
            'R',
            'R',
            'O',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Parrot"
        };

        animalName010 = new Question()
        {
            number = 10,
            questionName = "giraffe",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Giraffe"),
            answerBlocks = new List<char>()
        {
            'G',
            'I',
            'R',
            'A',
            'F',
            'F',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Giraffe"
        };

        animalName011 = new Question()
        {
            number = 11,
            questionName = "lion",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Lion"),
            answerBlocks = new List<char>()
        {
            'L',
            'I',
            'O',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lion"
        };

        animalName012 = new Question()
        {
            number = 12,
            questionName = "crocodile",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Crocodile"),
            answerBlocks = new List<char>()
        {
            'C',
            'R',
            'O',
            'C',
            'O',
            'D',
            'I',
            'L',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Crocodile"
        };



        animalName017 = new Question()
        {
            number = 17,
            questionName = "rabbit",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Rabbit"),
            answerBlocks = new List<char>()
        {
            'R',
            'A',
            'B',
            'B',
            'I',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Rabbit"
        };

        animalName018 = new Question()
        {
            number = 18,
            questionName = "frog",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Frog"),
            answerBlocks = new List<char>()
        {
            'F',
            'R',
            'O',
            'G'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Frog"
        };

        animalName019 = new Question()
        {
            number = 19,
            questionName = "tiger",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Tiger"),
            answerBlocks = new List<char>()
        {
            'T',
            'I',
            'G',
            'E',
            'R'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tiger"
        };


        animalName022 = new Question()
        {
            number = 22,
            questionName = "elephant",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Elephant"),
            answerBlocks = new List<char>()
        {
            'E',
            'L',
            'E',
            'P',
            'H',
            'A',
            'N',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Elephant"
        };

        animalName023 = new Question()
        {
            number = 23,
            questionName = "lizard",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Lizard"),
            answerBlocks = new List<char>()
        {
            'L',
            'I',
            'Z',
            'A',
            'R',
            'D'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Lizard"
        };

        animalName024 = new Question()
        {
            number = 24,
            questionName = "bat",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Bat"),
            answerBlocks = new List<char>()
        {
            'B',
            'A',
            'T'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Bat"
        };

        animalName025 = new Question()
        {
            number = 25,
            questionName = "eagle",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Eagle"),
            answerBlocks = new List<char>()
        {
            'E',
            'A',
            'G',
            'L',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Eagle"
        };

        animalName026 = new Question()
        {
            number = 26,
            questionName = "kangaroo",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Kangaroo"),
            answerBlocks = new List<char>()
        {
            'K',
            'A',
            'N',
            'G',
            'A',
            'R',
            'O',
            'O'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Kangaroo"
        };

        animalName027 = new Question()
        {
            number = 27,
            questionName = "panda",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Panda"),
            answerBlocks = new List<char>()
        {
            'P',
            'A',
            'N',
            'D',
            'A'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Panda"
        };

        animalName028 = new Question()
        {
            number = 28,
            questionName = "penguin",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Penguin"),
            answerBlocks = new List<char>()
        {
            'P',
            'E',
            'N',
            'G',
            'U',
            'I',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Penguin"
        };



        animalName030 = new Question()
        {
            number = 30,
            questionName = "snake",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Snake"),
            answerBlocks = new List<char>()
        {
            'S',
            'N',
            'A',
            'K',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Snake"
        };

        animalName031 = new Question()
        {
            number = 31,
            questionName = "swan",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Swan"),
            answerBlocks = new List<char>()
        {
            'S',
            'W',
            'A',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Swan"
        };

        animalName032 = new Question()
        {
            number = 32,
            questionName = "tortoise",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Tortoise"),
            answerBlocks = new List<char>()
        {
            'T',
            'O',
            'R',
            'T',
            'O',
            'I',
            'S',
            'E'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Tortoise"
        };

        animalName033 = new Question()
        {
            number = 33,
            questionName = "shark",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Shark"),
            answerBlocks = new List<char>()
        {
            'S',
            'H',
            'A',
            'R',
            'K'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Shark"
        };

        animalName034 = new Question()
        {
            number = 34,
            questionName = "dolphin",
            sprite = Resources.Load<Sprite>("V2/Questions/Animals/Dolphin"),
            answerBlocks = new List<char>()
        {
            'D',
            'O',
            'L',
            'P',
            'H',
            'I',
            'N'
        },
            tags = new List<string>()
        {
            "animals"
        },
            size = 1,
            answerSound = "Dolphin"
        };
    }

    public static void LoadQuestionList()
    {
        // if (!GameControl.animalName004known)
        questions.Add(animalName004);

        // if (!GameControl.animalName005known)
        questions.Add(animalName005);

        // if (!GameControl.animalName006known)
        questions.Add(animalName006);

        // if (!GameControl.animalName007known)
        questions.Add(animalName007);

        // if (!GameControl.animalName008known)
        questions.Add(animalName008);

        // if (!GameControl.animalName009known)
        questions.Add(animalName009);

        // if (!GameControl.animalName010known)
        questions.Add(animalName010);

        // if (!GameControl.animalName011known)
        questions.Add(animalName011);

        // if (!GameControl.animalName012known)
        questions.Add(animalName012);

        // if (!GameControl.animalName017known)
        questions.Add(animalName017);

        // if (!GameControl.animalName018known)
        questions.Add(animalName018);

        // if (!GameControl.animalName019known)
        questions.Add(animalName019);

        // if (!GameControl.animalName022known)
        questions.Add(animalName022);

        // if (!GameControl.animalName023known)
        questions.Add(animalName023);

        // if (!GameControl.animalName024known)
        questions.Add(animalName024);

        // if (!GameControl.animalName025known)
        questions.Add(animalName025);

        // if (!GameControl.animalName026known)
        questions.Add(animalName026);

        // if (!GameControl.animalName027known)
        questions.Add(animalName027);

        // if (!GameControl.animalName028known)
        questions.Add(animalName028);

        // if (!GameControl.animalName030known)
        questions.Add(animalName030);

        // if (!GameControl.animalName031known)
        questions.Add(animalName031);

        // if (!GameControl.animalName032known)
        questions.Add(animalName032);

        // if (!GameControl.animalName033known)
        questions.Add(animalName033);

        // if (!GameControl.animalName034known)
        questions.Add(animalName034);

        questions = questions.OrderBy(x => System.Guid.NewGuid()).ToList();

        Debug.Log(questions.Count);
    }

}
