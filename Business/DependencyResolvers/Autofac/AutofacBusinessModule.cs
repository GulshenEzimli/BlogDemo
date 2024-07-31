using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // business services
            builder.RegisterType<ArticleManager>().As<IArticleService> ().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<NewsLetterManager>().As<INewsLetterService>().SingleInstance();
            builder.RegisterType<AboutManager>().As<IAboutService>().SingleInstance();
            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();

            //db repositories
            builder.RegisterType<ArticleRepository>().As<IArticleRepository>().SingleInstance();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().SingleInstance();
            builder.RegisterType<CommentRepository>().As<ICommentRepository>().SingleInstance();
            builder.RegisterType<NewsLetterRepository>().As<INewsLetterRepository>().SingleInstance();
            builder.RegisterType<AboutRepository>().As<IAboutRepository>().SingleInstance();
            builder.RegisterType<ContactRepository>().As<IContactRepository>().SingleInstance();

            

        }
    }
}
