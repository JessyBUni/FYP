using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using detail_test.Models;

namespace detail_test.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { 
                    Id = Guid.NewGuid().ToString(),
                    Text = "Introduction", 
                    Description="What do you do with your emotions?" ,
                    ID=0,
                 },

                new Item { 
                    Id = Guid.NewGuid().ToString(),
                    Text = "Chapter 1 - Flow", 
                    Description="When we feel good we experience life as a flow. " +
                 	    "We can deal with whatever comes our way. Sometimes times " +
                 	    "this flow is interrupted and we feel stuck and struggle " +
                         "to respond to situations with ease. \n\n " +
                        "At these times when we may need a little support from " +
                        "others. Being able to ask for the support we need is " +
                        "not always easy and without your direction, people " +
                        "around you may be left to work out what to do for the " +
                        "best. Without having the information that they need this " +
                        "can be confusing and frustrating. \n\n " +
                        "In order to return to the flow of feeling good we have to do " +
                        "some internal detective work to find out what ‘obstacles’ " +
                        "need to be navigated. The methods highlighted in the " +
                        "following chapters will help you to work out what " +
                        "obstacles that you need to get around, get over, get " +
                        "through, reduce or remove to improve your emotional life " +
                        "and your relationships." ,
                    ID=1,
                    },


                new Item { 
                    Id = Guid.NewGuid().ToString(), 
                    Text = "Chapter 2 – Hidden Worlds", 
                    Description="Sometimes we hide or mask what is going on inside " +
                	    "of us and hope that no-one can see what is going on " +
                	    "behind the scenes. Sometimes we are unaware of what is " +
                	    "going on in our own inner world. We tend to have a private " +
                	    "face and a public face. It’s useful to let these two faces " +
                	"meet once in a while so that you can acknowledge for " +
                	"yourself what is going on behind the scenes. This way you " +
                	"have the advantage of full picture of your thoughts and " +
                	"feelings.\n\n" +
                    "The most important part of therapy is being ‘witnessed’, " +
                    "being listened to and being understood. Being witnessed " +
                    "by another persons important, however the most valuable " +
                    "event is learning to be your own witness. Learning to " +
                    "listen to your heart as well as your head is the key to " +
                    "this. Creativity is a route to your hearts expression."
                    ID=2,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 3 – Self Talk", 
                Description="The thoughts we have about ourselves have a huge " +
                	"impact on how we feel and this in turn effects how we " +
                	"behave and how we present ourselves. Negative thoughts " +
                	"can hold us back, whereas positive thoughts motivate us. " +
                	"It’s possible to adjust our thoughts, we often hear " +
                	"people saying ‘think positive’. Sometimes this is easier " +
                	"said than done. Especially when you are in the depths of " +
                	"negativity.\n\n" +
                    "We can put negative thoughts in context by acknowledging " +
                    "that they are often exaggerated fears rather than " +
                    "truths.  We can shift many of our negative thoughts " +
                    "purely by assessing how valid they really are.\n\n" +
                    "Learning to be more aware of our thoughts is a really " +
                    "useful exercise. It takes a bit of practice but will " +
                    "bring valuable long term benefits. We choose our " +
                    "thoughts and positive thoughts are always a worthwhile " +
                    "option. Positive thoughts lift our mood, our energy, our " +
                    "motivation and improve our behaviour." ,
                    ID=3,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 4 – Observing Emotions", 
                Description="Sometimes negative thoughts occur so often that " +
                	"they become habits. They flow like a river and we can " +
                	"get swept up in the current. It’s good to notice when " +
                	"this happens so that you can step out of them and watch " +
                	"them flow past you. It’s good to know that you have " +
                	"this choice. The more you practice this the easier it " +
                	"will become not to get caught up in them in the first " +
                	"place." ,
                    ID=4,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 5 – Defenses", 
                Description="We have mentioned how our thoughts effect " +
                	"emotions and behavior. In this chapter we are going to " +
                	"focus on how our behavior can expose emotional unease. " +
                	"Sometimes the things that we say and the manner in " +
                	"which we say them don’t match e.g saying ‘I don’t care " +
                	"what you think’ can be an indication that another " +
                	"person’s opinion has really bothered you. Similarly " +
                	"saying ‘I’m not bothered’ could be an indication that " +
                	"you are bothered but don’t want to admit that you are. " +
                	"Our behavior can alert other people to the fact that " +
                	"we are being defensive by trying to hide our true " +
                	"emotions." ,
                    ID=5,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 6 – Distractions", 
                Description="At times we might use specific behaviours that " +
                	"distract ourselves and other people from how we are " +
                	"feeling. It is useful for us to be aware what our " +
                	"distraction behavior patterns are, so that at times " +
                	"when they arise we can make a decision about whether " +
                	"we want to continue to use them or whether we would " +
                	"benefit from attending to how we are feeling. Both " +
                	"defenses and distractions are devises that are " +
                	"sometimes necessary to help us deal with situations " +
                	"that we are in. It’s not always practical to deal " +
                	"with emotions at the moment that they arise, so we do " +
                	"need to have methods to hold them at bay. However " +
                	"holding emotions at bay is not a long term solution. " +
                	"Defenses and distraction behaviours are alerts that let " +
                	"us know that something needs attending to and that we " +
                	"need to find time to reflect on our thoughts and feelings." ,
                    ID=6,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 7 – Exploring Emotions", 
                Description="We can get a lot of information about emotions " +
                	"by describing our feelings.\n\n" +
                    "It can difficult at times to translate our feelings " +
                    "into words. Expressive arts can help us to explore " +
                    "feelings. Drawing our emotions is a great method. " +
                    "You don’t have to be ‘good’ at drawing just willing to " +
                    "represent your feelings on paper. Once expressed it is " +
                    "easier to find the words to describe the feeling " +
                    "that has been drawn.\n\n" +
                    "It is really useful to use the same method to draw and " +
                    "explore the opposite of the emotion that you have " +
                    "identified. This can give you a lot of information and " +
                    "insight about the things that you can do to transform " +
                    "your emotions. This is a great method for learning to " +
                    "talk about feelings." ,
                    ID=7,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 8 – Cycles of Life", 
                Description="All things in life undergo a process of cycles. " +
                	"Recognising cycles in nature can beautifully put into " +
                	"perspective the cycles that we go through, during our " +
                	"lives." ,
                    ID=8,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 9 – Abstract Realities", 
                Description="Time and time again we hear people come to the " +
                	"conclusion that they are not good enough. In this " +
                	"belief there is the assumption that everyone else " +
                	"around them is in some way better than them.\n\n" +
                	"We are all extremely complex individuals navigating " +
                	"our own personal set of obstacles in the best way that " +
                	"we know how. We are all capable of getting stuck and we are " +
                	"all capable of being more than we are. Our imperfections " +
                	"are a matter of perception being open to adapting our " +
                	"perceptions when we need to, is an art and a skill that " +
                	"will serve us well.\n\n" +
                	"In the following workshop exercise each person was " +
                	"asked to improvise dialogue to represent the image that " +
                	"they were given. In the second part of the workshop " +
                	"they were asked to choose an image that represents " +
                	"how they see themselves.",
                    ID=9,
                     },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 10 – Storymaking", 
                Description="Working with fantasy stories can provide " +
                	"benefits for our emotional health. Stories give us a " +
                	"‘space’ to work things out. They give us the opportunity " +
                	"to problem solve and master obstacles. Thinking about our " +
                	"favourite characters from stories can give us some " +
                	"insight into the sort of qualities that we value and " +
                	"maybe even aspire to.\n\n" +
                    "When we create stories we work with our emotions. Stories " +
                    "give us the chance to take a journey through the " +
                    "‘landscapes’ of some of our unconscious material where " +
                    "we can discover what issues we are dealing with that " +
                    "we might not be fully aware of.\n\n" +
                    "The following videos were taken from a workshops where " +
                    "we used a story making method based on the work of Alida " +
                    "Gersie, Mooli Lahad and Kim Dent-Brown\n\n" +
                    "To begin, a main character was invented. This character " +
                    "had a task to do but encountered an obstacle, which " +
                    "prevented them from doing the task. A helper was " +
                    "found that supported them in finding a solution and " +
                    "completing the task." ,
                    ID=10,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 11 – Using Emotions to Reclaim Your Power", 
                Description="All emotions are beautiful things. Some may feel " +
                	"more beautiful than others but they are all an indication " +
                	"that you are human, you have needs and you may have " +
                	"issues that need to be resolved. Emotions if used well " +
                	"will help you to find these resolutions. They are like a " +
                	"compass that can show you when to stop, when to turn and " +
                	"when to keep going.\n\n" +
                    "The name of our emotions can be difficult to find. And " +
                    "like Rumplestiltskin whilst remaining un-named they can " +
                    "have power over us.\n\n" +
                    "All of the processes that we have covered so far lead " +
                    "show how identifying our emotions is an important " +
                    "process. When we can see them for what they are we can " +
                    "begin to reclaim our power." ,
                    ID=11,
                    },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 12 – Following your Emotions", 
                Description="In this program you have been introduced to " +
                	"processes that will help you to recognise the impacts " +
                	"of your emotions and how to increase your awareness of " +
                	"them. In this chapter you will be introduced to a " +
                	"method that will help you to make ‘contact’ with " +
                	"your emotions.\n\n" +
                	"Sometimes when we have a strong emotion, we can locate " +
                	"the tension that we are feeling from that emotion in a " +
                	"part of our body. This is where we are said to be " +
                	"‘holding’ that emotion.\n\n" +
                	"Using  focused meditation you can take an imaginary " +
                	"journey to that place in your body where you are " +
                	"holding that emotion and allow the tension that it has " +
                	"created to be released.\n\n" +
                    "The only way to appreciate how this works is to do it " +
                    "for real when you are feeling a strong emotion that you " +
                    "want to release.",
                    ID=12,
                     },

                new Item { 
                Id = Guid.NewGuid().ToString(), 
                Text = "Chapter 13 – Peace of Mind", 
                Description="We regularly need to make the time to relax, " +
                	"ground our energies and re-set our focus. Meditative " +
                	"practices are used to restore our minds and allow us to " +
                	"detach from life’s dramas. They give us the space to " +
                	"connect to the essence of who we really are.\n\n" +
                	"Taking deep breaths is a simple and extremely effective " +
                	"way of calming the mind. It is a method that can be " +
                	"used anytime anywhere.\n\n" +
                	"Guided meditations can assist you to relax through a " +
                	"combination of breath work and visualisation." ,
                    ID=13,
                    },

            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}