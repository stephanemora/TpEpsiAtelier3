using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatchClub;

namespace TestMatchClub2
{
    [TestClass]
    public class TestClub
    {
        [TestMethod]
        public void PeutRetournerLeNomDuClub()
        {
            String nomDuClub = "unClubPourri";
            Club unClub = new Club(nomDuClub);
            Assert.AreEqual(unClub.ToString(), nomDuClub); 
        }
    }
    
    [TestClass]
    public class TestMatch
    {
        private Club unClubBienPourriHome;
        private Club unClubAuHasartAway;

        [TestInitialize]
        public void Initialiser()
        {
            unClubBienPourriHome = new Club("unClubBienPourri");
            unClubAuHasartAway = new Club("unClubAuHasart");
        }

        [TestMethod]
        public void PeutRetournerLeBonClubHome()
        {
            Match unMatch = new Match(unClubBienPourriHome, unClubAuHasartAway, false, false);
            Assert.AreEqual(unMatch.Home, unClubBienPourriHome);
        }

        [TestMethod]
        public void PeutRetournerLeBonClubAway()
        {
            Match unMatch = new Match(unClubBienPourriHome, unClubAuHasartAway, false, false);
            Assert.AreEqual(unMatch.Away, unClubAuHasartAway);
        }

        [TestMethod]
        public void PeutRetournerLeBonNombreDeButDuClubHome()
        {
            Match unMatch = new Match(unClubBienPourriHome, unClubAuHasartAway, 1, 0);
            Assert.AreEqual(1, unMatch.HomeGoals);
        }

        [TestMethod]
        public void PeutRetourneLeBonNombreDeButDuClubAway()
        {
            Match unMatch = new Match(unClubBienPourriHome, unClubAuHasartAway, 0, 1);
            Assert.AreEqual(1, unMatch.AwayGoals);
        }

        [TestMethod]
        public void PeutSavoirSiLeClubHomeAFaitForfait()
        {
            Match unMatch = new Match(unClubBienPourriHome, unClubAuHasartAway, true, false);
            Assert.AreEqual(true, unMatch.IsHomeForfeit);
        }

        [TestMethod]
        public void PeutSavoirSiLeClubAwayAFaitForfait()
        {
            Match unMatch = new Match(unClubBienPourriHome, unClubAuHasartAway, false, true);
            Assert.AreEqual(true, unMatch.IsAwayForfeit);
        }

        [TestMethod]
        public void PeutSavoirSiLesCLubOntFaitUnMatchNull()
        {
            Match unMatch = new Match(unClubBienPourriHome, unClubAuHasartAway, 1, 1);
            Assert.AreEqual(true, unMatch.IsDraw);
        }
    }
}
