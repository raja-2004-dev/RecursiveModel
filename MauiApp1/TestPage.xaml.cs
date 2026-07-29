using MauiApp1.Models;
namespace MauiApp1;


    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

            ComponentsCollectionView.ItemsSource = GetModels();
        }

    List<RecursiveModel> GetModels()
    {
        return new List<RecursiveModel>
    {
        new RecursiveModel
        {
            Name = "Main",
            Directories = new List<RecursiveModel>
            {
                new RecursiveModel
                {
                    Name = "Folder 1",
                    Directories = new List<RecursiveModel>
                    {
                        new RecursiveModel
                        {
                            Name = "test.doc"
                        },
                        new RecursiveModel
                        {
                            Name = "notes.pdf"
                        },
                        new RecursiveModel
                        {
                            Name = "Sub Folder",
                            Directories = new List<RecursiveModel>
                            {
                                new RecursiveModel
                                {
                                    Name = "test.doc"
                                },
                                new RecursiveModel
                                {
                                    Name = "Images",
                                    Directories = new List<RecursiveModel>
                                    {
                                        new RecursiveModel
                                        {
                                            Name = "photo1.png"
                                        },
                                        new RecursiveModel
                                        {
                                            Name = "photo2.jpg"
                                        }
                                    }
                                }
                            }
                        }
                    }
                },

                new RecursiveModel
                {
                    Name = "Folder 2",
                    Directories = new List<RecursiveModel>
                    {
                        new RecursiveModel
                        {
                            Name = "test.doc"
                        },
                        new RecursiveModel
                        {
                            Name = "test2.doc"
                        },
                        new RecursiveModel
                        {
                            Name = "Reports",
                            Directories = new List<RecursiveModel>
                            {
                                new RecursiveModel
                                {
                                    Name = "January.xlsx"
                                },
                                new RecursiveModel
                                {
                                    Name = "February.xlsx"
                                },
                                new RecursiveModel
                                {
                                    Name = "Archive",
                                    Directories = new List<RecursiveModel>
                                    {
                                        new RecursiveModel
                                        {
                                            Name = "2024.zip"
                                        },
                                        new RecursiveModel
                                        {
                                            Name = "2025.zip"
                                        }
                                    }
                                }
                            }
                        }
                    }
                },

                new RecursiveModel
                {
                    Name = "Documents",
                    Directories = new List<RecursiveModel>
                    {
                        new RecursiveModel
                        {
                            Name = "Resume.docx"
                        },
                        new RecursiveModel
                        {
                            Name = "Invoice.pdf"
                        },
                        new RecursiveModel
                        {
                            Name = "Projects",
                            Directories = new List<RecursiveModel>
                            {
                                new RecursiveModel
                                {
                                    Name = "Project A",
                                    Directories = new List<RecursiveModel>
                                    {
                                        new RecursiveModel
                                        {
                                            Name = "Requirements.docx"
                                        },
                                        new RecursiveModel
                                        {
                                            Name = "Design.pdf"
                                        }
                                    }
                                },
                                new RecursiveModel
                                {
                                    Name = "Project B",
                                    Directories = new List<RecursiveModel>
                                    {
                                        new RecursiveModel
                                        {
                                            Name = "Budget.xlsx"
                                        },
                                        new RecursiveModel
                                        {
                                            Name = "Presentation.pptx"
                                        }
                                    }
                                }
                            }
                        }
                    }
                },

                new RecursiveModel
                {
                    Name = "Downloads",
                    Directories = new List<RecursiveModel>
                    {
                        new RecursiveModel
                        {
                            Name = "Software",
                            Directories = new List<RecursiveModel>
                            {
                                new RecursiveModel
                                {
                                    Name = "VisualStudio.exe"
                                },
                                new RecursiveModel
                                {
                                    Name = "AndroidStudio.exe"
                                }
                            }
                        },
                        new RecursiveModel
                        {
                            Name = "Music",
                            Directories = new List<RecursiveModel>
                            {
                                new RecursiveModel
                                {
                                    Name = "Song1.mp3"
                                },
                                new RecursiveModel
                                {
                                    Name = "Song2.mp3"
                                }
                            }
                        }
                    }
                },

                new RecursiveModel
                {
                    Name = "Pictures",
                    Directories = new List<RecursiveModel>
                    {
                        new RecursiveModel
                        {
                            Name = "Vacation",
                            Directories = new List<RecursiveModel>
                            {
                                new RecursiveModel
                                {
                                    Name = "Beach.png"
                                },
                                new RecursiveModel
                                {
                                    Name = "Mountain.jpg"
                                }
                            }
                        },
                        new RecursiveModel
                        {
                            Name = "Family",
                            Directories = new List<RecursiveModel>
                            {
                                new RecursiveModel
                                {
                                    Name = "Dad.png"
                                },
                                new RecursiveModel
                                {
                                    Name = "Mom.png"
                                },
                                new RecursiveModel
                                {
                                    Name = "Brother.png"
                                }
                            }
                        }
                    }
                }
            }
        }
    };
    }
}

