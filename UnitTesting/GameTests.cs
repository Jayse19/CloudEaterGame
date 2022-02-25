//using NUnit.Framework;
//using System.Threading.Tasks;
//using FluentAssertions;
//using MobileCloudEaterApp.ViewModels;
//using System.Linq;
//using Moq;
//using MobileCloudEaterApp.Services;
//using Mobile.ViewModels;

//namespace UnitTesting
//{
//    public class Tests
//    {
//        [SetUp]
//        public void Setup()
//        {
//        }

//        [Test]
//        public async Task AbleToJoinGame()
//        {
//            var mock = new Mock<IAPIService>();
//            mock.Setup(m => m.JoinGameAsync(It.IsAny<string>(), It.IsAny<string>()))
//                .ReturnsAsync("I Joined the Game");
//            var videoGameViewModel = new VideoGameViewModel(mock.Object);
//            await videoGameViewModel.JoinGameCommand.ExecuteAsync(this);

//            videoGameViewModel.IsSignupVisible.Should().BeFalse();
//            videoGameViewModel.ArePlayControlsVisible.Should().BeTrue();
//        }
//        [Test]
//        public async Task UnAbleToJoinGame()
//        {
//            var mock = new Mock<IAPIService>();
//            mock.Setup(m => m.JoinGameAsync(It.IsAny<string>(), It.IsAny<string>()))
//                .ReturnsAsync("Failed to Join the Game");
//            var videoGameViewModel = new VideoGameViewModel(mock.Object);
//            await videoGameViewModel.JoinGameCommand.ExecuteAsync(this);

//            videoGameViewModel.IsSignupVisible.Should().BeTrue();
//            videoGameViewModel.ArePlayControlsVisible.Should().BeFalse();
//        }
//        [Test]
//        public void MoqAPIService()
//        {
//            var moqAPI = new Mock<IAPIService>();
//            moqAPI.Should().NotBeNull();
//        }
//    }
//}