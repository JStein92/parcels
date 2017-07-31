using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System;
using System.Collections.Generic;
namespace Parcel.Controllers
{
  public class HomeController : Controller
  {


    [Route("/Form")]
    public ActionResult Form()
    {
      Console.WriteLine("Form route found");
      return View();
    }

    [Route("/Order")]
    public ActionResult Order()
    {
      ParcelVariables myParcel = new ParcelVariables();
      myParcel.SetHeight(float.Parse(Request.Query["height"]));
      myParcel.SetWidth(float.Parse(Request.Query["width"]));
      myParcel.SetDepth(float.Parse(Request.Query["depth"]));
      myParcel.SetWeight(float.Parse(Request.Query["weight"]));

      ParcelVariables parcel1 = new ParcelVariables();
      parcel1.SetHeight(10);
      parcel1.SetWidth(20);
      parcel1.SetWeight(5);
      parcel1.SetDepth(15);

      ParcelVariables parcel2 = new ParcelVariables();
      parcel2.SetHeight(30);
      parcel2.SetWidth(23);
      parcel2.SetWeight(3);
      parcel2.SetDepth(13);

      List<ParcelVariables> parcelList = new List<ParcelVariables>();
      parcelList.Add(myParcel);
      parcelList.Add(parcel1);
      parcelList.Add(parcel2);

      //Console.WriteLine(parcelList.Count);

      return View("Order",parcelList);
    }
  }
}
